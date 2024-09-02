using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Stops sending each frame in the `screencastFrame`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StopScreencastCommandParams: ICommandParams<StopScreencastCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.StopScreencast;
	}
}
