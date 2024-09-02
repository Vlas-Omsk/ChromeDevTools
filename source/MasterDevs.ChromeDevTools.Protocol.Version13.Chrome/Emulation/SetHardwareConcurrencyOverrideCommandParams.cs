using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{

	[SupportedBy("Chrome")]
	public class SetHardwareConcurrencyOverrideCommandParams: ICommandParams<SetHardwareConcurrencyOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetHardwareConcurrencyOverride;
		/// <summary>
		/// Hardware concurrency to report
		/// </summary>
		public long HardwareConcurrency { get; set; }
	}
}
