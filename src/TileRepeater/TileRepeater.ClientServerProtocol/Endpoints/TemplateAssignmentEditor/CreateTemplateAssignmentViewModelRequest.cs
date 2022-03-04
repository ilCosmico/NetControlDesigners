﻿using System;
using Microsoft.DotNet.DesignTools.Protocol;
using Microsoft.DotNet.DesignTools.Protocol.DataPipe;
using Microsoft.DotNet.DesignTools.Protocol.Endpoints;

namespace WinForms.Tiles.Designer.Protocol.Endpoints
{
    public class CreateTemplateAssignmentViewModelRequest : Request
    {
        public SessionId SessionId { get; private set; }
        public object? TileRepeaterTemplateAssignmentProxy { get; private set; }

        public CreateTemplateAssignmentViewModelRequest() { }

        public CreateTemplateAssignmentViewModelRequest(SessionId sessionId, object tileRepeaterTemplateAssignmentProxy)
        {
            SessionId = sessionId.IsNull ? throw new ArgumentNullException(nameof(sessionId)) : sessionId;
            TileRepeaterTemplateAssignmentProxy = tileRepeaterTemplateAssignmentProxy;
        }

        public CreateTemplateAssignmentViewModelRequest(IDataPipeReader reader) : base(reader) { }

        protected override void ReadProperties(IDataPipeReader reader)
        {
            SessionId = reader.ReadSessionId(nameof(SessionId));
            TileRepeaterTemplateAssignmentProxy = reader.ReadObject(nameof(TileRepeaterTemplateAssignmentProxy));
        }

        protected override void WriteProperties(IDataPipeWriter writer)
        {
            writer.Write(nameof(SessionId), SessionId);
            writer.WriteObject(nameof(TileRepeaterTemplateAssignmentProxy), TileRepeaterTemplateAssignmentProxy);
        }
    }
}