using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Target
{
	/// <summary>
	/// Returns information about a target.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetTargetInfoCommandResult : ICommandResult
	{
		/// <summary>
		/// TargetInfo
		/// </summary>
		public TargetInfo TargetInfo { get; set; }
	}
}
