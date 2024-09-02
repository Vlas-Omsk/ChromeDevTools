using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that a new AudioListener has been created.
	/// </summary>
	[EventName(ProtocolName.WebAudio.AudioListenerWillBeDestroyed)]
	[SupportedBy("Chrome")]
	public class AudioListenerWillBeDestroyedEventParams : IEventParams
	{
		/// <summary>
		/// ContextId
		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// ListenerId
		/// </summary>
		public string ListenerId { get; set; }
	}
}
