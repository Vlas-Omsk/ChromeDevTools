using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Sets the timing of an animation node.
	/// </summary>
	[Command(ProtocolName.Animation.SetTiming)]
	[SupportedBy("Chrome")]
	public class SetTimingCommand: IProtocolCommand<SetTimingCommandResponse>
	{
		/// <summary>
		/// Animation id.
		/// </summary>
		public string AnimationId { get; set; }
		/// <summary>
		/// Duration of the animation.
		/// </summary>
		public double Duration { get; set; }
		/// <summary>
		/// Delay of the animation.
		/// </summary>
		public double Delay { get; set; }
	}
}
