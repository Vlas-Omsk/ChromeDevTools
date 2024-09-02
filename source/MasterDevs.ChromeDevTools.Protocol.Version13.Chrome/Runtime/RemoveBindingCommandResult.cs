using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// This method does not remove binding function from global object but
	/// unsubscribes current runtime agent from Runtime.bindingCalled notifications.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RemoveBindingCommandResult : ICommandResult
	{
	}
}
