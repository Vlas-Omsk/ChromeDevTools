using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Target
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
