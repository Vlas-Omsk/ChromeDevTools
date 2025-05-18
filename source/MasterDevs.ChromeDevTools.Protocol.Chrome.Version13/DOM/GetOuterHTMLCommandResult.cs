using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
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
