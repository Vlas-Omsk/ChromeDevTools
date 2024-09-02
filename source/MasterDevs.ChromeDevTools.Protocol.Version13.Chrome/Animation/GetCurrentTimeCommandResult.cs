using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Animation
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
