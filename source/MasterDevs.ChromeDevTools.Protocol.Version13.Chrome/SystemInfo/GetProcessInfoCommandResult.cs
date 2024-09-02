using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.SystemInfo
{
	/// <summary>
	/// Returns information about all running processes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetProcessInfoCommandResult : ICommandResult
	{
		/// <summary>
		/// An array of process info blocks.
		/// </summary>
		public ProcessInfo[] ProcessInfo { get; set; }
	}
}
