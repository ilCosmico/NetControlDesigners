﻿using Microsoft.DotNet.DesignTools.Protocol;
using Microsoft.DotNet.DesignTools.Protocol.DataPipe;
using Microsoft.DotNet.DesignTools.Protocol.Endpoints;
using System;

namespace CustomControlLibrary.ClientServerCommunication.Endpoints
{
    /// <summary>
    ///  Request class for the CreateCustomTypeEditorViewModel endpoint. This passes the necessary
    ///  context  (<c>SessionId</c>, proxy of the <c>CustomControl</c>) from the client to the server.
    /// </summary>
    public class CreateCustomTypeEditorViewModelRequest : Request
    {
        public SessionId SessionId { get; private set; }
        public object? CustomControlProxy { get; private set; }

        public CreateCustomTypeEditorViewModelRequest() { }

        public CreateCustomTypeEditorViewModelRequest(SessionId sessionId, object? customControlProxy)
        {
            SessionId = sessionId.IsNull ? throw new ArgumentNullException(nameof(sessionId)) : sessionId;
            CustomControlProxy = customControlProxy;
        }

        public CreateCustomTypeEditorViewModelRequest(IDataPipeReader reader) : base(reader) { }

        protected override void ReadProperties(IDataPipeReader reader)
        {
            SessionId = reader.ReadSessionId(nameof(SessionId));
            CustomControlProxy = reader.ReadObject(nameof(CustomControlProxy));
        }

        protected override void WriteProperties(IDataPipeWriter writer)
        {
            writer.Write(nameof(SessionId), SessionId);
            writer.WriteObject(nameof(CustomControlProxy), CustomControlProxy);
        }
    }
}
