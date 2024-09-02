using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Fired when user cancels the inspect mode.
	/// </summary>
	[EventName(ProtocolName.Overlay.InspectModeCanceled)]
	[SupportedBy("Chrome")]
	public class InspectModeCanceledEventParams : IEventParams
	{
	}
}
