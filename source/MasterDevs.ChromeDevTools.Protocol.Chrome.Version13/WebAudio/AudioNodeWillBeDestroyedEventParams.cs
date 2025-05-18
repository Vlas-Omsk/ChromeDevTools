using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAudio
{
	/// <summary>
	/// Notifies that an existing AudioNode has been destroyed.
	/// </summary>
	[EventName(ProtocolName.WebAudio.AudioNodeWillBeDestroyed)]
	[SupportedBy("Chrome")]
	public class AudioNodeWillBeDestroyedEventParams : IEventParams
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
