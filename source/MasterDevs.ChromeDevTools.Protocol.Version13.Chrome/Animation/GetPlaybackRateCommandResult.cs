using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Animation
{
	/// <summary>
	/// Gets the playback rate of the document timeline.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetPlaybackRateCommandResult : ICommandResult
	{
		/// <summary>
		/// Playback rate for animations on page.
		/// </summary>
		public double PlaybackRate { get; set; }
	}
}
