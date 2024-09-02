using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Evaluates given script in every frame upon creation (before loading frame's scripts).
	/// </summary>

	[SupportedBy("Chrome")]
	public class AddScriptToEvaluateOnNewDocumentCommandResult : ICommandResult
	{
		/// <summary>
		/// Identifier of the added script.
		/// </summary>
		public string Identifier { get; set; }
	}
}
