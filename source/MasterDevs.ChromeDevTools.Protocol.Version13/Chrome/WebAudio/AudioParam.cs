using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Protocol object for AudioParam
	/// </summary>
	[SupportedBy("Chrome")]
	public class AudioParam
	{
		/// <summary>
		/// ParamId
		/// </summary>
		public string ParamId { get; set; }
		/// <summary>
		/// NodeId
		/// </summary>
		public string NodeId { get; set; }
		/// <summary>
		/// ContextId
		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// ParamType
		/// </summary>
		public string ParamType { get; set; }
		/// <summary>
		/// Rate
		/// </summary>
		public AutomationRate Rate { get; set; }
		/// <summary>
		/// DefaultValue
		/// </summary>
		public double DefaultValue { get; set; }
		/// <summary>
		/// MinValue
		/// </summary>
		public double MinValue { get; set; }
		/// <summary>
		/// MaxValue
		/// </summary>
		public double MaxValue { get; set; }
	}
}
