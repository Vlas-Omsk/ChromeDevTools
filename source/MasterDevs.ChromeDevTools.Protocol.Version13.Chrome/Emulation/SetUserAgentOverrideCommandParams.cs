using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Allows overriding user agent with the given string.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetUserAgentOverrideCommandParams: ICommandParams<SetUserAgentOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetUserAgentOverride;
		/// <summary>
		/// User agent to use.
		/// </summary>
		public string UserAgent { get; set; }
		/// <summary>
		/// Browser langugage to emulate.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string AcceptLanguage { get; set; }
		/// <summary>
		/// The platform navigator.platform should return.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Platform { get; set; }
		/// <summary>
		/// To be sent in Sec-CH-UA-* headers and returned in navigator.userAgentData
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public UserAgentMetadata UserAgentMetadata { get; set; }
	}
}
