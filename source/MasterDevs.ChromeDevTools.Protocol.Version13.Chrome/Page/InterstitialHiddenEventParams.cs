using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
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
