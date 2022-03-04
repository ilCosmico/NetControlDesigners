﻿using Microsoft.DotNet.DesignTools.ViewModels;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using TileRepeater.ClientServerProtocol;
using WinForms.Tiles.Designer.Protocol.Endpoints;

namespace TileRepeater.Designer.Server
{
    internal partial class TemplateAssignmentViewModel : ViewModel
    {
        private ITypeDiscoveryService? _typeResolutionService;

        private const string SystemNamespace = "System";
        private const string MicrosoftNamespace = "Microsoft";
        private const string AccessibilityNamespace = "Accessibility";
        private const string WinFormsTileType = "WinForms.Tiles.Tile";

        private static readonly string[] s_systemAssembliesFilter = new[]
        {
            AccessibilityNamespace,
            $"{SystemNamespace}.",
            $"{MicrosoftNamespace}."
        };

        public TemplateAssignmentViewModel(IServiceProvider provider)
            : base(provider)
        {
        }

        public CreateTemplateAssignmentViewModelResponse Initialize()
        {
            // Here in the Server process, we first get the list of potential template types...
            TemplateTypeList = GetTemplateTypelist();

            // ...and then every type which is derived from 'Tile'.
            TitleTypeList = GetTileTypeList();
            return new CreateTemplateAssignmentViewModelResponse(this, TemplateTypeList, TitleTypeList);
        }

        public TypeInfoData[] TemplateTypeList { get; private set; } = null!;
        public TypeInfoData[] TitleTypeList { get; private set; } = null!;

        private TypeInfoData[] GetTemplateTypelist()
        {
            _typeResolutionService ??= GetRequiredService<ITypeDiscoveryService>();

            var types = _typeResolutionService.GetTypes(typeof(object), true)
                .Cast<Type>()

                .Where(typeItem => !typeItem.IsAbstract && !typeItem.IsInterface &&
                                   !typeItem.IsEnum && typeItem.IsPublic && !typeItem.IsGenericType &&

                                   // We have a few assemblies, whose types we never want.
                                   !s_systemAssembliesFilter.Any(
                                       notWantedPrefix => typeItem.FullName!.StartsWith(notWantedPrefix)))

                .Select(typeItem => new TypeInfoData(
                    typeItem.Assembly.FullName!,
                    typeItem.Namespace ?? string.Empty,
                    typeItem.FullName!,
                    typeItem.AssemblyQualifiedName!,
                    typeof(INotifyPropertyChanged).IsAssignableFrom(typeItem),
                    typeItem.Name))
                .OrderBy(typeItem => typeItem.Namespace)
                .ThenBy(typeItem => typeItem.Name);

            return types.ToArray();
        }

        private TypeInfoData[] GetTileTypeList()
        {
            _typeResolutionService ??= GetRequiredService<ITypeDiscoveryService>();

            var types = _typeResolutionService.GetTypes(typeof(object), true)
                .Cast<Type>()
                .Where(typeItem => !typeItem.IsAbstract && !typeItem.IsInterface &&
                                   !typeItem.IsEnum && typeItem.IsPublic && !typeItem.IsGenericType &&

                                   // We only want types derived from WinForms.Tiles.Tile.
                                   typeItem.IsAssignableFrom(Type.GetType(WinFormsTileType)))

                .Select(typeItem => new TypeInfoData(
                    typeItem.Assembly.FullName!,
                    typeItem.Namespace ?? string.Empty,
                    typeItem.FullName!,
                    typeItem.AssemblyQualifiedName!,
                    typeof(INotifyPropertyChanged).IsAssignableFrom(typeItem),
                    typeItem.Name))
                .OrderBy(typeItem => typeItem.Namespace)
                .ThenBy(typeItem => typeItem.Name);

            return types.ToArray();
        }
    }
}