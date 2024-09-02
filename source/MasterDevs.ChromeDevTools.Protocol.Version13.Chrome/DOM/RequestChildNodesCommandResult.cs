using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Requests that children of the node with given id are returned to the caller in form of
	/// `setChildNodes` events where not only immediate children are retrieved, but all children down to
	/// the specified depth.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RequestChildNodesCommandResult : ICommandResult
	{
	}
}
