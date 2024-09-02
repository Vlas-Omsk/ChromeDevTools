using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Returns the root DOM node to the caller.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetDocumentCommandParams: ICommandParams<GetDocumentCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetDocument;
	}
}
