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
	public class GetDocumentCommandResult : ICommandResult
	{
		/// <summary>
		/// Resulting node.
		/// </summary>
		public Node Root { get; set; }
	}
}
