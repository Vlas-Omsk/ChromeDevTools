using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Deletes browser cookies with matching name and url or domain/path pair.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DeleteCookiesCommandResult : ICommandResult
	{
	}
}
