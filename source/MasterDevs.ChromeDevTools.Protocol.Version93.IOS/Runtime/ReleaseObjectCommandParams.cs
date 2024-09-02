using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Releases remote object with given id.
	/// </summary>

	[SupportedBy("IOS")]
	public class ReleaseObjectCommandParams: ICommandParams<ReleaseObjectCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.ReleaseObject;
		/// <summary>
		/// Identifier of the object to release.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
