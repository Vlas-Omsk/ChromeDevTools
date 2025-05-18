using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Debugger
{
	/// <summary>
	/// Resumes JavaScript execution.
	/// </summary>

	[SupportedBy("IOS")]
	public class ResumeCommand: ICommand<ResumeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.Resume;
	}
}
