using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted.
	/// Backend then generates 'inspectNodeRequested' event upon element selection.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetInspectModeCommandResult : ICommandResult
	{
	}
}
