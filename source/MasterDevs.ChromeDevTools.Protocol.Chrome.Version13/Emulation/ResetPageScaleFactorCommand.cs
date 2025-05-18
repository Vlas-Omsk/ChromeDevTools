using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{
	/// <summary>
	/// Requests that page scale factor is reset to initial values.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ResetPageScaleFactorCommand: ICommand<ResetPageScaleFactorCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.ResetPageScaleFactor;
	}
}
