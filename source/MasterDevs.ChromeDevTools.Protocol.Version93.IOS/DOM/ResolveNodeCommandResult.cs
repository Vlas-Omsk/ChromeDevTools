using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Resolves JavaScript node object for given node id.
	/// </summary>

	[SupportedBy("IOS")]
	public class ResolveNodeCommandResult : ICommandResult
	{
		/// <summary>
		/// JavaScript object wrapper for given node.
		/// </summary>
		public Runtime.RemoteObject Object { get; set; }
	}
}
