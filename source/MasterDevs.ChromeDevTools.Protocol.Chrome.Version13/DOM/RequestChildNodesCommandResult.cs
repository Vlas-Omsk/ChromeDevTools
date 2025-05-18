using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
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
