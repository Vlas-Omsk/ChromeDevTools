using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Runtime
{
	/// <summary>
	/// Releases remote object with given id.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ReleaseObjectCommand: ICommand<ReleaseObjectCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.ReleaseObject;
		/// <summary>
		/// Identifier of the object to release.
		/// </summary>
		public string ObjectId { get; set; }
	}
}
