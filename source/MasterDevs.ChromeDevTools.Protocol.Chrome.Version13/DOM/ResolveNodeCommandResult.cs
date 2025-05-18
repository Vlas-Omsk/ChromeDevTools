using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Resolves the JavaScript node object for a given NodeId or BackendNodeId.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ResolveNodeCommandResult : ICommandResult
	{
		/// <summary>
		/// JavaScript object wrapper for given node.
		/// </summary>
		public Runtime.RemoteObject Object { get; set; }
	}
}
