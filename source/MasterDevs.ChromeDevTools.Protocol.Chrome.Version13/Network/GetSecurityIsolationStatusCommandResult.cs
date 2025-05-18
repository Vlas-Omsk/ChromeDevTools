using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Returns information about the COEP/COOP isolation status.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetSecurityIsolationStatusCommandResult : ICommandResult
	{
		/// <summary>
		/// Status
		/// </summary>
		public SecurityIsolationStatus Status { get; set; }
	}
}
