using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Retrieves a list of available targets.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetTargetsCommandResult : ICommandResult
	{
		/// <summary>
		/// The list of targets.
		/// </summary>
		public TargetInfo[] TargetInfos { get; set; }
	}
}
