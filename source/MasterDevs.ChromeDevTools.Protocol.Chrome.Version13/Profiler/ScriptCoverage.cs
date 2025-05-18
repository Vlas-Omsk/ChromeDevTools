using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Profiler
{
	/// <summary>
	/// Coverage data for a JavaScript script.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ScriptCoverage
	{
		/// <summary>
		/// JavaScript script id.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// JavaScript script name or url.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Functions contained in the script that has coverage data.
		/// </summary>
		public FunctionCoverage[] Functions { get; set; }
	}
}
