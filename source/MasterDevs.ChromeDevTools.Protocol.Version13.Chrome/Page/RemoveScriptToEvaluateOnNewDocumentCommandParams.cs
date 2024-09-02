using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Removes given script from the list.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RemoveScriptToEvaluateOnNewDocumentCommandParams: ICommandParams<RemoveScriptToEvaluateOnNewDocumentCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.RemoveScriptToEvaluateOnNewDocument;
		/// <summary>
		/// Identifier
		/// </summary>
		public string Identifier { get; set; }
	}
}
