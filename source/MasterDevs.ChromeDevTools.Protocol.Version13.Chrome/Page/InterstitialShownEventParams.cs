using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Fired when interstitial page was shown
	/// </summary>
	[EventName(ProtocolName.Page.InterstitialShown)]
	[SupportedBy("Chrome")]
	public class InterstitialShownEventParams : IEventParams
	{
	}
}
