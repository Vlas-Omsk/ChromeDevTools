using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Protocol object for AudioNode
	/// </summary>
	[SupportedBy("Chrome")]
	public class AudioNode
	{
		/// <summary>
		/// NodeId
		/// </summary>
		public string NodeId { get; set; }
		/// <summary>
		/// ContextId
		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// NodeType
		/// </summary>
		public string NodeType { get; set; }
		/// <summary>
		/// NumberOfInputs
		/// </summary>
		public double NumberOfInputs { get; set; }
		/// <summary>
		/// NumberOfOutputs
		/// </summary>
		public double NumberOfOutputs { get; set; }
		/// <summary>
		/// ChannelCount
		/// </summary>
		public double ChannelCount { get; set; }
		/// <summary>
		/// ChannelCountMode
		/// </summary>
		public ChannelCountMode ChannelCountMode { get; set; }
		/// <summary>
		/// ChannelInterpretation
		/// </summary>
		public ChannelInterpretation ChannelInterpretation { get; set; }
	}
}
