using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Sets or clears an override of the default background color of the frame. This override is used
	/// if the content does not specify one.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetDefaultBackgroundColorOverrideCommandResult : ICommandResult
	{
	}
}
