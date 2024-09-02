using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAudio
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
