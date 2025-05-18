using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Runtime
{
	/// <summary>
	/// Releases all remote objects that belong to a given group.
	/// </summary>

	[SupportedBy("IOS")]
	public class ReleaseObjectGroupCommand: ICommand<ReleaseObjectGroupCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.ReleaseObjectGroup;
		/// <summary>
		/// Symbolic object group name.
		/// </summary>
		public string ObjectGroup { get; set; }
	}
}
