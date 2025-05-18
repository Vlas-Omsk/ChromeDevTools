using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Preload
{
	/// <summary>
	/// Send a list of sources for all preloading attempts.
	/// </summary>
	[EventName(ProtocolName.Preload.PreloadingAttemptSourcesUpdated)]
	[SupportedBy("Chrome")]
	public class PreloadingAttemptSourcesUpdatedEventParams : IEventParams
	{
		/// <summary>
		/// PreloadingAttemptSources
		/// </summary>
		public PreloadingAttemptSource[] PreloadingAttemptSources { get; set; }
	}
}
