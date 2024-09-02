using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Fired once navigation of the frame has completed. Frame is now associated with the new loader.
	/// </summary>
	[EventName(ProtocolName.Page.FrameNavigated)]
	[SupportedBy("Chrome")]
	public class FrameNavigatedEventParams : IEventParams
	{
		/// <summary>
		/// Frame object.
		/// </summary>
		public Frame Frame { get; set; }
		/// <summary>
		/// Type
		/// </summary>
		public NavigationType Type { get; set; }
	}
}
