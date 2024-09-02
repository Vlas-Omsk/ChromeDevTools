using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Security
{
	/// <summary>
	/// Enable/disable whether all certificate errors should be ignored.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetIgnoreCertificateErrorsCommandResult : ICommandResult
	{
	}
}
