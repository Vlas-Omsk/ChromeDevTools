using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Returns node's HTML markup.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetOuterHTMLCommandResult : ICommandResult
	{
		/// <summary>
		/// Outer HTML markup.
		/// </summary>
		public string OuterHTML { get; set; }
	}
}
