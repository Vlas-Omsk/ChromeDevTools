using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that a new BaseAudioContext has been created.
	/// </summary>
	[EventName(ProtocolName.WebAudio.ContextCreated)]
	[SupportedBy("Chrome")]
	public class ContextCreatedEventParams : IEventParams
	{
		/// <summary>
		/// Context
		/// </summary>
		public BaseAudioContext Context { get; set; }
	}
}
