using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions or no exceptions. Initial pause on exceptions state is <code>none</code>.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetPauseOnExceptionsCommandParams: ICommandParams<SetPauseOnExceptionsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetPauseOnExceptions;
		/// <summary>
		/// Pause on exceptions mode.
		/// </summary>
		public string State { get; set; }
	}
}
