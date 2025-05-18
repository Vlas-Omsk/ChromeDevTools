using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAudio
{
	/// <summary>
	/// Notifies that a new AudioNode has been created.
	/// </summary>
	[EventName(ProtocolName.WebAudio.AudioNodeCreated)]
	[SupportedBy("Chrome")]
	public class AudioNodeCreatedEventParams : IEventParams
	{
		/// <summary>
		/// Node
		/// </summary>
		public AudioNode Node { get; set; }
	}
}
