using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Performance
{
	/// <summary>
	/// Enable collecting and reporting metrics.
	/// </summary>
	[Command(ProtocolName.Performance.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommand: IProtocolCommand<EnableCommandResponse>
	{
		/// <summary>
		/// Time domain to use for collecting and reporting duration metrics.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TimeDomain { get; set; }
	}
}
