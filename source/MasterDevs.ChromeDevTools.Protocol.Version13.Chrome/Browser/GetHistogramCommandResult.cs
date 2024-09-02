using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Get a Chrome histogram by name.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetHistogramCommandResult : ICommandResult
	{
		/// <summary>
		/// Histogram.
		/// </summary>
		public Histogram Histogram { get; set; }
	}
}
