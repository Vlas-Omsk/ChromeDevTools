using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that a new AudioParam has been created.
	/// </summary>
	[Event(ProtocolName.WebAudio.AudioParamCreated)]
	[SupportedBy("Chrome")]
	public class AudioParamCreatedEvent
	{
		/// <summary>
		/// Param
		/// </summary>
		public AudioParam Param { get; set; }
	}
}
