using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
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
