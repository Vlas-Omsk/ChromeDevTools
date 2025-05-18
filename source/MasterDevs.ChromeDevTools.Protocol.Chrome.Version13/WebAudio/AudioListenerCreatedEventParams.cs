using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAudio
{
	/// <summary>
	/// Notifies that the construction of an AudioListener has finished.
	/// </summary>
	[EventName(ProtocolName.WebAudio.AudioListenerCreated)]
	[SupportedBy("Chrome")]
	public class AudioListenerCreatedEventParams : IEventParams
	{
		/// <summary>
		/// Listener
		/// </summary>
		public AudioListener Listener { get; set; }
	}
}
