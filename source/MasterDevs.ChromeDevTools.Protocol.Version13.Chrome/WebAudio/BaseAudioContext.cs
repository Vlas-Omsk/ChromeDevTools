using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAudio
{
	/// <summary>
	/// Protocol object for BaseAudioContext
	/// </summary>
	[SupportedBy("Chrome")]
	public class BaseAudioContext
	{
		/// <summary>
		/// ContextId
		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// ContextType
		/// </summary>
		public ContextType ContextType { get; set; }
		/// <summary>
		/// ContextState
		/// </summary>
		public ContextState ContextState { get; set; }
		/// <summary>
		/// RealtimeData
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ContextRealtimeData RealtimeData { get; set; }
		/// <summary>
		/// Platform-dependent callback buffer size.
		/// </summary>
		public double CallbackBufferSize { get; set; }
		/// <summary>
		/// Number of output channels supported by audio hardware in use.
		/// </summary>
		public double MaxOutputChannelCount { get; set; }
		/// <summary>
		/// Context sample rate.
		/// </summary>
		public double SampleRate { get; set; }
	}
}
