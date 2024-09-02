using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Animation
{
	/// <summary>
	/// Sets the timing of an animation node.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetTimingCommandParams: ICommandParams<SetTimingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Animation.SetTiming;
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
