using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Releases all remote objects that belong to a given group.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ReleaseObjectGroupCommandParams: ICommandParams<ReleaseObjectGroupCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.ReleaseObjectGroup;
		/// <summary>
		/// Symbolic object group name.
		/// </summary>
		public string ObjectGroup { get; set; }
	}
}
