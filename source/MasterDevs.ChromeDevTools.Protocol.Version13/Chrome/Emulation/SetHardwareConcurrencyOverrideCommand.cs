using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	[Command(ProtocolName.Emulation.SetHardwareConcurrencyOverride)]
	[SupportedBy("Chrome")]
	public class SetHardwareConcurrencyOverrideCommand: IProtocolCommand<SetHardwareConcurrencyOverrideCommandResponse>
	{
		/// <summary>
		/// Hardware concurrency to report
		/// </summary>
		public long HardwareConcurrency { get; set; }
	}
}
