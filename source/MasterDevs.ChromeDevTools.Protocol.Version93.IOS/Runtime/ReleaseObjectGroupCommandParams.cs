using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Releases all remote objects that belong to a given group.
	/// </summary>

	[SupportedBy("IOS")]
	public class ReleaseObjectGroupCommandParams: ICommandParams<ReleaseObjectGroupCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.ReleaseObjectGroup;
		/// <summary>
		/// Symbolic object group name.
		/// </summary>
		public string ObjectGroup { get; set; }
	}
}
