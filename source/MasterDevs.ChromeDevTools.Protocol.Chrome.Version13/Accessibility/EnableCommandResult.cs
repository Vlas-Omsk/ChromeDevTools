using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Accessibility
{
	/// <summary>
	/// Enables the accessibility domain which causes `AXNodeId`s to remain consistent between method calls.
	/// This turns on accessibility for the page, which can impact performance until accessibility is disabled.
	/// </summary>

	[SupportedBy("Chrome")]
	public class EnableCommandResult : ICommandResult
	{
	}
}
