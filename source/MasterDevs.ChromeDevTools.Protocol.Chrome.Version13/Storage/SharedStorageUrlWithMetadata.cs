using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Bundles a candidate URL with its reporting metadata.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SharedStorageUrlWithMetadata
	{
		/// <summary>
		/// Spec of candidate URL.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Any associated reporting metadata.
		/// </summary>
		public SharedStorageReportingMetadata[] ReportingMetadata { get; set; }
	}
}
