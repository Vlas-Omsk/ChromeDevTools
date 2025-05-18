using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Runtime
{
	/// <summary>
	/// Discards collected exceptions and console API calls.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DiscardConsoleEntriesCommand: ICommand<DiscardConsoleEntriesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.DiscardConsoleEntries;
	}
}
