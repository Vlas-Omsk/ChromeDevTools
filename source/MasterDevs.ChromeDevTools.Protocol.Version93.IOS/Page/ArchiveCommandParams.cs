using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Grab an archive of the page.
	/// </summary>

	[SupportedBy("IOS")]
	public class ArchiveCommandParams: ICommandParams<ArchiveCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.Archive;
	}
}
