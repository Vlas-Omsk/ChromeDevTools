using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Audits
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
