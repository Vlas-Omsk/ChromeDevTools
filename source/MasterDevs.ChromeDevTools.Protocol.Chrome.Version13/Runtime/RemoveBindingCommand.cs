using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Runtime
{
	/// <summary>
	/// This method does not remove binding function from global object but
	/// unsubscribes current runtime agent from Runtime.bindingCalled notifications.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RemoveBindingCommand: ICommand<RemoveBindingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.RemoveBinding;
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }
	}
}
