using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM
{
	/// <summary>
	/// Returns the root DOM node to the caller.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetDocumentCommand: ICommand<GetDocumentCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetDocument;
	}
}
