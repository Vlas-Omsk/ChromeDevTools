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
	public class GetHistogramsCommand: ICommand<GetHistogramsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.GetHistograms;
		/// <summary>
		/// Requested substring in name. Only histograms which have query as a
		/// substring in their name are extracted. An empty or absent query returns
		/// all histograms.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Query { get; set; }
		/// <summary>
		/// If true, retrieve delta since last delta call.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Delta { get; set; }
	}
}
