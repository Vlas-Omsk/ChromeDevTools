using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Debugger
{
	/// <summary>
	/// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions or no exceptions. Initial pause on exceptions state is <code>none</code>.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetPauseOnExceptionsCommand: ICommand<SetPauseOnExceptionsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetPauseOnExceptions;
		/// <summary>
		/// Pause on exceptions mode.
		/// </summary>
		public string State { get; set; }
	}
}
