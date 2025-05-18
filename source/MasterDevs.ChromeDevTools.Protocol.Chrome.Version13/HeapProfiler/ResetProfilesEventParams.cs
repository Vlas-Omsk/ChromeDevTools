using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.HeapProfiler
{
	[EventName(ProtocolName.HeapProfiler.ResetProfiles)]
	[SupportedBy("Chrome")]
	public class ResetProfilesEventParams : IEventParams
	{
	}
}
