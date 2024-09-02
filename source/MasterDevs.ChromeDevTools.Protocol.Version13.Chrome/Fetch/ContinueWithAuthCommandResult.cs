using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Fetch
{
	/// <summary>
	/// Continues a request supplying authChallengeResponse following authRequired event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ContinueWithAuthCommandResult : ICommandResult
	{
	}
}
