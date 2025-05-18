using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
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
