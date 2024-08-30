using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Releases all remote objects that belong to a given group.
	/// </summary>
	[Command(ProtocolName.Runtime.ReleaseObjectGroup)]
	[SupportedBy("Chrome")]
	public class ReleaseObjectGroupCommand: ICommandParams<ReleaseObjectGroupCommandResponse>
	{
		/// <summary>
		/// Symbolic object group name.
		/// </summary>
		public string ObjectGroup { get; set; }
	}
}
