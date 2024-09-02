using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Audits
{
	/// <summary>
	/// Runs the contrast check for the target page. Found issues are reported
	/// using Audits.issueAdded event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CheckContrastCommandResult : ICommandResult
	{
	}
}
