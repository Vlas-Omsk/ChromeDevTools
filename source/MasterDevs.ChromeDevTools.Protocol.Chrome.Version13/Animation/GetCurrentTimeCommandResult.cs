using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Animation
{
	/// <summary>
	/// Returns the current time of the an animation.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCurrentTimeCommandResult : ICommandResult
	{
		/// <summary>
		/// Current time of the page.
		/// </summary>
		public double CurrentTime { get; set; }
	}
}
