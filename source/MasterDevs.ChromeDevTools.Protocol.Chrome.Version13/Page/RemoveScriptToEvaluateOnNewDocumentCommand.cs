using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Removes given script from the list.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RemoveScriptToEvaluateOnNewDocumentCommand: ICommand<RemoveScriptToEvaluateOnNewDocumentCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.RemoveScriptToEvaluateOnNewDocument;
		/// <summary>
		/// Identifier
		/// </summary>
		public string Identifier { get; set; }
	}
}
