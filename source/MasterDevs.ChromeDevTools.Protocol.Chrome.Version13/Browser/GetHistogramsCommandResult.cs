using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Browser
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
