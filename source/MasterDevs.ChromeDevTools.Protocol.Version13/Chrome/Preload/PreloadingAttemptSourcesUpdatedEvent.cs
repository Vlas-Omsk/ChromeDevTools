using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	/// Send a list of sources for all preloading attempts.
	/// </summary>
	[Event(ProtocolName.Preload.PreloadingAttemptSourcesUpdated)]
	[SupportedBy("Chrome")]
	public class PreloadingAttemptSourcesUpdatedEvent
	{
		/// <summary>
		/// PreloadingAttemptSources
		/// </summary>
		public PreloadingAttemptSource[] PreloadingAttemptSources { get; set; }
	}
}
