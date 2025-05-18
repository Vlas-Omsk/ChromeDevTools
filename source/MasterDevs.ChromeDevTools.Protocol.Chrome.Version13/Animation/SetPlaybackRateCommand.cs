using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Animation
{
	/// <summary>
	/// Sets the playback rate of the document timeline.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetPlaybackRateCommand: ICommand<SetPlaybackRateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Animation.SetPlaybackRate;
		/// <summary>
		/// Playback rate for animations on page
		/// </summary>
		public double PlaybackRate { get; set; }
	}
}
