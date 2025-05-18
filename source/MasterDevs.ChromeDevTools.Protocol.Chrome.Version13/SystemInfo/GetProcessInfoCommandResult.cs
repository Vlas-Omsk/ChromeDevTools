using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.SystemInfo
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
