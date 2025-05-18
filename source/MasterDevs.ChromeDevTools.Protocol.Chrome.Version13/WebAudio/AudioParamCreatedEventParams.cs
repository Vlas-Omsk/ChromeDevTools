using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAudio
{
	/// <summary>
	/// Notifies that a new AudioParam has been created.
	/// </summary>
	[EventName(ProtocolName.WebAudio.AudioParamCreated)]
	[SupportedBy("Chrome")]
	public class AudioParamCreatedEventParams : IEventParams
	{
		/// <summary>
		/// Param
		/// </summary>
		public AudioParam Param { get; set; }
	}
}
