using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Returns usage and quota in bytes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetUsageAndQuotaCommandParams: ICommandParams<GetUsageAndQuotaCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.GetUsageAndQuota;
		/// <summary>
		/// Security origin.
		/// </summary>
		public string Origin { get; set; }
	}
}
