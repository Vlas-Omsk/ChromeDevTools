using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
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
