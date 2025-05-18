using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	[EventName(ProtocolName.Page.FrameResized)]
	[SupportedBy("Chrome")]
	public class FrameResizedEventParams : IEventParams
	{
	}
}
