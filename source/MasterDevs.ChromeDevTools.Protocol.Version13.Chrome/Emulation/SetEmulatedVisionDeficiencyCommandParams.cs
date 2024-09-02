using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Emulates the given vision deficiency.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetEmulatedVisionDeficiencyCommandParams: ICommandParams<SetEmulatedVisionDeficiencyCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetEmulatedVisionDeficiency;
		/// <summary>
		/// Vision deficiency to emulate. Order: best-effort emulations come first, followed by any
		/// physiologically accurate emulations for medically recognized color vision deficiencies.
		/// </summary>
		public string Type { get; set; }
	}
}
