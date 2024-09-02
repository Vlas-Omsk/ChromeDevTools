using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Audits
{
	[SupportedBy("Chrome")]
	public class SourceCodeLocation
	{
		/// <summary>
		/// ScriptId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ScriptId { get; set; }
		/// <summary>
		/// Url
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// LineNumber
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// ColumnNumber
		/// </summary>
		public long ColumnNumber { get; set; }
	}
}
