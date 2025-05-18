using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAudio
{
	/// <summary>
	/// Notifies that an existing AudioParam has been destroyed.
	/// </summary>
	[EventName(ProtocolName.WebAudio.AudioParamWillBeDestroyed)]
	[SupportedBy("Chrome")]
	public class AudioParamWillBeDestroyedEventParams : IEventParams
	{
		/// <summary>
		/// ContextId
		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// NodeId
		/// </summary>
		public string NodeId { get; set; }
		/// <summary>
		/// ParamId
		/// </summary>
		public string ParamId { get; set; }
	}
}
