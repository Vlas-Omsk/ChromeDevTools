using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Debugger
{
	/// <summary>
	/// Continues execution until specific location is reached.
	/// </summary>

	[SupportedBy("IOS")]
	public class ContinueToLocationCommand: ICommand<ContinueToLocationCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.ContinueToLocation;
		/// <summary>
		/// Location to continue to.
		/// </summary>
		public Location Location { get; set; }
	}
}
