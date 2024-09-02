using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns quads that describe node position on the page. This method
	/// might return multiple quads for inline nodes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetContentQuadsCommandResult : ICommandResult
	{
		/// <summary>
		/// Quads that describe node layout relative to viewport.
		/// </summary>
		public double[][] Quads { get; set; }
	}
}
