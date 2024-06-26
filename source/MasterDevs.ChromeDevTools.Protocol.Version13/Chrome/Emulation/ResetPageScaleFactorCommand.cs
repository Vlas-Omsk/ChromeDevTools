using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Requests that page scale factor is reset to initial values.
	/// </summary>
	[Command(ProtocolName.Emulation.ResetPageScaleFactor)]
	[SupportedBy("Chrome")]
	public class ResetPageScaleFactorCommand: IProtocolCommand<ResetPageScaleFactorCommandResponse>
	{
	}
}
