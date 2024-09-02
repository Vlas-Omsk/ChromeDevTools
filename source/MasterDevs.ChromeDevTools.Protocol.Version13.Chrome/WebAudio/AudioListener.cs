using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAudio
{
	/// <summary>
	/// Protocol object for AudioListener
	/// </summary>
	[SupportedBy("Chrome")]
	public class AudioListener
	{
		/// <summary>
		/// ListenerId
		/// </summary>
		public string ListenerId { get; set; }
		/// <summary>
		/// ContextId
		/// </summary>
		public string ContextId { get; set; }
	}
}
