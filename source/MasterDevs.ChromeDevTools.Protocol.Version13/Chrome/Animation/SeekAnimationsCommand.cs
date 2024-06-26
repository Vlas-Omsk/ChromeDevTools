using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Seek a set of animations to a particular time within each animation.
	/// </summary>
	[Command(ProtocolName.Animation.SeekAnimations)]
	[SupportedBy("Chrome")]
	public class SeekAnimationsCommand: IProtocolCommand<SeekAnimationsCommandResponse>
	{
		/// <summary>
		/// List of animation ids to seek.
		/// </summary>
		public string[] Animations { get; set; }
		/// <summary>
		/// Set the current time of each animation.
		/// </summary>
		public double CurrentTime { get; set; }
	}
}
