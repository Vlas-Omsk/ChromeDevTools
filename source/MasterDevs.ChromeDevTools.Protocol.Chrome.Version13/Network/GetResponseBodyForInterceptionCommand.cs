using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Returns content served for the given currently intercepted request.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetResponseBodyForInterceptionCommand: ICommand<GetResponseBodyForInterceptionCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.GetResponseBodyForInterception;
		/// <summary>
		/// Identifier for the intercepted request to get body for.
		/// </summary>
		public string InterceptionId { get; set; }
	}
}
