using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Requests that page scale factor is reset to initial values.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ResetPageScaleFactorCommandResult : ICommandResult
	{
	}
}
