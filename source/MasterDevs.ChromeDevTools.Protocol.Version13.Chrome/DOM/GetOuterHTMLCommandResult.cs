using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns node's HTML markup.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetOuterHTMLCommandResult : ICommandResult
	{
		/// <summary>
		/// Outer HTML markup.
		/// </summary>
		public string OuterHTML { get; set; }
	}
}
