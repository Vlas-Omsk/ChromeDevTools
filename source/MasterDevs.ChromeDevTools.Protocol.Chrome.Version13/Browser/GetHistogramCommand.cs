using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Browser
{
	/// <summary>
	/// Get a Chrome histogram by name.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetHistogramCommand: ICommand<GetHistogramCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.GetHistogram;
		/// <summary>
		/// Requested histogram name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// If true, retrieve delta since last delta call.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Delta { get; set; }
	}
}
