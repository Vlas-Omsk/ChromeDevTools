using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Obtain list of rules that became used since last call to this method (or since start of coverage
	/// instrumentation).
	/// </summary>

	[SupportedBy("Chrome")]
	public class TakeCoverageDeltaCommandParams: ICommandParams<TakeCoverageDeltaCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.TakeCoverageDelta;
	}
}
