using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{
	/// <summary>
	/// Fired once navigation of the frame has completed. Frame is now associated with the new loader.
	/// </summary>
	[EventName(ProtocolName.Page.FrameNavigated)]
	[SupportedBy("IOS")]
	public class FrameNavigatedEventParams : IEventParams
	{
		/// <summary>
		/// Frame object.
		/// </summary>
		public Frame Frame { get; set; }
	}
}
