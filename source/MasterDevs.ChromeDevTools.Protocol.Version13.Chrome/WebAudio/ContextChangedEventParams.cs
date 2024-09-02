using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that existing BaseAudioContext has changed some properties (id stays the same)..
	/// </summary>
	[EventName(ProtocolName.WebAudio.ContextChanged)]
	[SupportedBy("Chrome")]
	public class ContextChangedEventParams : IEventParams
	{
		/// <summary>
		/// Context
		/// </summary>
		public BaseAudioContext Context { get; set; }
	}
}
