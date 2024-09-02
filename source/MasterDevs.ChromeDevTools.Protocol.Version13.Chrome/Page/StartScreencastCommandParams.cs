using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Starts sending each frame using the `screencastFrame` event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartScreencastCommandParams: ICommandParams<StartScreencastCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.StartScreencast;
		/// <summary>
		/// Image compression format.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Format { get; set; }
		/// <summary>
		/// Compression quality from range [0..100].
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Quality { get; set; }
		/// <summary>
		/// Maximum screenshot width.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MaxWidth { get; set; }
		/// <summary>
		/// Maximum screenshot height.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MaxHeight { get; set; }
		/// <summary>
		/// Send every n-th frame.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? EveryNthFrame { get; set; }
	}
}
