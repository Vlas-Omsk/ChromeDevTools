using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Continues execution until specific location is reached.
	/// </summary>

	[SupportedBy("IOS")]
	public class ContinueToLocationCommandParams: ICommandParams<ContinueToLocationCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.ContinueToLocation;
		/// <summary>
		/// Location to continue to.
		/// </summary>
		public Location Location { get; set; }
	}
}
