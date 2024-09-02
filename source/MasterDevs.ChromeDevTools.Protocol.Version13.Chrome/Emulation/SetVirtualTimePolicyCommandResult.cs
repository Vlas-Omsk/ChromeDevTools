using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Turns on virtual time for all frames (replacing real-time with a synthetic time source) and sets
	/// the current virtual time policy.  Note this supersedes any previous time budget.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetVirtualTimePolicyCommandResult : ICommandResult
	{
		/// <summary>
		/// Absolute timestamp at which virtual time was first enabled (up time in milliseconds).
		/// </summary>
		public double VirtualTimeTicksBase { get; set; }
	}
}
