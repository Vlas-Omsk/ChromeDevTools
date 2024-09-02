using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Defines pause on exceptions state. Can be set to stop on all exceptions, uncaught exceptions,
	/// or caught exceptions, no exceptions. Initial pause on exceptions state is `none`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetPauseOnExceptionsCommandParams: ICommandParams<SetPauseOnExceptionsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetPauseOnExceptions;
		/// <summary>
		/// Pause on exceptions mode.
		/// </summary>
		public string State { get; set; }
	}
}
