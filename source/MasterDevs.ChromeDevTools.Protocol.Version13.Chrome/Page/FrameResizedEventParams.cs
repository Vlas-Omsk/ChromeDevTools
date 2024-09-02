using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	[EventName(ProtocolName.Page.FrameResized)]
	[SupportedBy("Chrome")]
	public class FrameResizedEventParams : IEventParams
	{
	}
}
