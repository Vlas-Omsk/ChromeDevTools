using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
{
	/// <summary>
	/// Fires if any of the regionOverset values changed in a Named Flow's region chain.
	/// </summary>
	[EventName(ProtocolName.CSS.RegionOversetChanged)]
	[SupportedBy("IOS")]
	public class RegionOversetChangedEventParams : IEventParams
	{
		/// <summary>
		/// The Named Flow containing the regions whose regionOverset values changed.
		/// </summary>
		public NamedFlow NamedFlow { get; set; }
	}
}
