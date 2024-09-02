using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Fires whenever a MediaQuery result changes (for example, after a browser window has been resized.) The current implementation considers only viewport-dependent media features.
	/// </summary>
	[EventName(ProtocolName.CSS.MediaQueryResultChanged)]
	[SupportedBy("IOS")]
	public class MediaQueryResultChangedEventParams : IEventParams
	{
	}
}
