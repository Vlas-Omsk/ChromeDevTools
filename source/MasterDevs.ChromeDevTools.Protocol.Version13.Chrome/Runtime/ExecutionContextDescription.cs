using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Description of an isolated world.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ExecutionContextDescription
	{
		/// <summary>
		/// Unique id of the execution context. It can be used to specify in which execution context
		/// script evaluation should be performed.
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// Execution context origin.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Human readable name describing given context.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// A system-unique execution context identifier. Unlike the id, this is unique across
		/// multiple processes, so can be reliably used to identify specific context while backend
		/// performs a cross-process navigation.
		/// </summary>
		public string UniqueId { get; set; }
		/// <summary>
		/// Embedder-specific auxiliary data.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object AuxData { get; set; }
	}
}
