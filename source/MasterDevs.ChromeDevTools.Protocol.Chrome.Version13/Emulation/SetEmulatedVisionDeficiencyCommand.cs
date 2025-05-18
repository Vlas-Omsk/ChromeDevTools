using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{
	/// <summary>
	/// Emulates the given vision deficiency.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetEmulatedVisionDeficiencyCommand: ICommand<SetEmulatedVisionDeficiencyCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetEmulatedVisionDeficiency;
		/// <summary>
		/// Vision deficiency to emulate. Order: best-effort emulations come first, followed by any
		/// physiologically accurate emulations for medically recognized color vision deficiencies.
		/// </summary>
		public string Type { get; set; }
	}
}
