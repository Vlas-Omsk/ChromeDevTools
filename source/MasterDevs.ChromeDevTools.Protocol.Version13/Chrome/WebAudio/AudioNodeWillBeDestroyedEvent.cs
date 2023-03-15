using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that an existing AudioNode has been destroyed.
	/// </summary>
	[Event(ProtocolName.WebAudio.AudioNodeWillBeDestroyed)]
	[SupportedBy("Chrome")]
	public class AudioNodeWillBeDestroyedEvent
	{
		/// <summary>
		/// ContextId
		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// NodeId
		/// </summary>
		public string NodeId { get; set; }
	}
}
