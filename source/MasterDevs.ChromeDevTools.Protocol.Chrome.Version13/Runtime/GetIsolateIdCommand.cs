using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Runtime
{
	/// <summary>
	/// Returns the isolate id.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetIsolateIdCommand: ICommand<GetIsolateIdCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.GetIsolateId;
	}
}
