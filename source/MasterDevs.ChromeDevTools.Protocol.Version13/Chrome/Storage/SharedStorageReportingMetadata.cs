using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Pair of reporting metadata details for a candidate URL for `selectURL()`.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SharedStorageReportingMetadata
	{
		/// <summary>
		/// EventType
		/// </summary>
		public string EventType { get; set; }
		/// <summary>
		/// ReportingUrl
		/// </summary>
		public string ReportingUrl { get; set; }
	}
}
