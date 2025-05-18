using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
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
