using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.HeapProfiler
{
	[EventName(ProtocolName.HeapProfiler.ResetProfiles)]
	[SupportedBy("Chrome")]
	public class ResetProfilesEventParams : IEventParams
	{
	}
}
