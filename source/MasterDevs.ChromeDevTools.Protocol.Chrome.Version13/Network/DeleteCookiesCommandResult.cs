using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Deletes browser cookies with matching name and url or domain/path pair.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DeleteCookiesCommandResult : ICommandResult
	{
	}
}
