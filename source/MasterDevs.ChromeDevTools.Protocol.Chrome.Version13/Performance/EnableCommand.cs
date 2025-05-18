using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Performance
{
	/// <summary>
	/// Enable collecting and reporting metrics.
	/// </summary>

	[SupportedBy("Chrome")]
	public class EnableCommand: ICommand<EnableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Performance.Enable;
		/// <summary>
		/// Time domain to use for collecting and reporting duration metrics.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TimeDomain { get; set; }
	}
}
