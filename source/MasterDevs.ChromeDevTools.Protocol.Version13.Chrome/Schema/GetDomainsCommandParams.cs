using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Schema
{
	/// <summary>
	/// Returns supported domains.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetDomainsCommandParams: ICommandParams<GetDomainsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Schema.GetDomains;
	}
}
