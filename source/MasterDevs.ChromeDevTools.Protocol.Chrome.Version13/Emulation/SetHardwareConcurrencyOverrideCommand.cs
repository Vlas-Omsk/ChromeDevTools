using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{

	[SupportedBy("Chrome")]
	public class SetHardwareConcurrencyOverrideCommand: ICommand<SetHardwareConcurrencyOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetHardwareConcurrencyOverride;
		/// <summary>
		/// Hardware concurrency to report
		/// </summary>
		public long HardwareConcurrency { get; set; }
	}
}
