using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Animation
{
	/// <summary>
	/// Sets the playback rate of the document timeline.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetPlaybackRateCommandParams: ICommandParams<SetPlaybackRateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Animation.SetPlaybackRate;
		/// <summary>
		/// Playback rate for animations on page
		/// </summary>
		public double PlaybackRate { get; set; }
	}
}
