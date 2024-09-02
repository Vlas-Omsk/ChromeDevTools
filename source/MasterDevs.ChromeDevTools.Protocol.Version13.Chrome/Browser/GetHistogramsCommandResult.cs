using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Get Chrome histograms.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetHistogramsCommandResult : ICommandResult
	{
		/// <summary>
		/// Histograms.
		/// </summary>
		public Histogram[] Histograms { get; set; }
	}
}
