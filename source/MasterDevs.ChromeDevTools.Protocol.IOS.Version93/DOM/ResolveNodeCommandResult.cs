using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM
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
