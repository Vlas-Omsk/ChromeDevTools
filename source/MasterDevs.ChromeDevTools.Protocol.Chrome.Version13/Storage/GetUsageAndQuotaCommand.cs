using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Returns usage and quota in bytes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetUsageAndQuotaCommand: ICommand<GetUsageAndQuotaCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.GetUsageAndQuota;
		/// <summary>
		/// Security origin.
		/// </summary>
		public string Origin { get; set; }
	}
}
