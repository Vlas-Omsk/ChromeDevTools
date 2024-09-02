using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that an existing BaseAudioContext will be destroyed.
	/// </summary>
	[EventName(ProtocolName.WebAudio.ContextWillBeDestroyed)]
	[SupportedBy("Chrome")]
	public class ContextWillBeDestroyedEventParams : IEventParams
	{
		/// <summary>
		/// ContextId
		/// </summary>
		public string ContextId { get; set; }
	}
}
