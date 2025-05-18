using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Runtime
{
	/// <summary>
	/// Enables reporting of execution contexts creation by means of <code>executionContextCreated</code> event. When the reporting gets enabled the event will be sent immediately for each existing execution context.
	/// </summary>

	[SupportedBy("IOS")]
	public class EnableCommand: ICommand<EnableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.Enable;
	}
}
