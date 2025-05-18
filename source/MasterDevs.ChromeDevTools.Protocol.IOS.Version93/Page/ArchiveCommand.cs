using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{
	/// <summary>
	/// Grab an archive of the page.
	/// </summary>

	[SupportedBy("IOS")]
	public class ArchiveCommand: ICommand<ArchiveCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.Archive;
	}
}
