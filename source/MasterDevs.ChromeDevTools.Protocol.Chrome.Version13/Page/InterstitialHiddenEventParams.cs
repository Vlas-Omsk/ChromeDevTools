using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Fired when interstitial page was hidden
	/// </summary>
	[EventName(ProtocolName.Page.InterstitialHidden)]
	[SupportedBy("Chrome")]
	public class InterstitialHiddenEventParams : IEventParams
	{
	}
}
