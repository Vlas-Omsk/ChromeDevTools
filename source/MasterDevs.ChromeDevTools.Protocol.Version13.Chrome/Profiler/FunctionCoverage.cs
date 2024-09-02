using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Profiler
{
	/// <summary>
	/// Coverage data for a JavaScript function.
	/// </summary>
	[SupportedBy("Chrome")]
	public class FunctionCoverage
	{
		/// <summary>
		/// JavaScript function name.
		/// </summary>
		public string FunctionName { get; set; }
		/// <summary>
		/// Source ranges inside the function with coverage data.
		/// </summary>
		public CoverageRange[] Ranges { get; set; }
		/// <summary>
		/// Whether coverage data for this function has block granularity.
		/// </summary>
		public bool IsBlockCoverage { get; set; }
	}
}
