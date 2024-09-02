using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Profiler
{

	[SupportedBy("Chrome")]
	public class StopCommandResult : ICommandResult
	{
		/// <summary>
		/// Recorded profile.
		/// </summary>
		public Profile Profile { get; set; }
	}
}
