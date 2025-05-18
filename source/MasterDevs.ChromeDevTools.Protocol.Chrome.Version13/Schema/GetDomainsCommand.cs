using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Schema
{
	/// <summary>
	/// Returns supported domains.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetDomainsCommand: ICommand<GetDomainsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Schema.GetDomains;
	}
}
