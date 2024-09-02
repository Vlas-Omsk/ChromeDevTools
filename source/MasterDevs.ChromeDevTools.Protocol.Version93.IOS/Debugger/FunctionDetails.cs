using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Information about the function.
	/// </summary>
	[SupportedBy("IOS")]
	public class FunctionDetails
	{
		/// <summary>
		/// Location of the function.
		/// </summary>
		public Location Location { get; set; }
		/// <summary>
		/// Name of the function. Not present for anonymous functions.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
		/// <summary>
		/// Display name of the function(specified in 'displayName' property on the function object).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DisplayName { get; set; }
		/// <summary>
		/// Name of the function inferred from its initial assignment.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string InferredName { get; set; }
		/// <summary>
		/// Scope chain for this closure.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Scope[] ScopeChain { get; set; }
	}
}
