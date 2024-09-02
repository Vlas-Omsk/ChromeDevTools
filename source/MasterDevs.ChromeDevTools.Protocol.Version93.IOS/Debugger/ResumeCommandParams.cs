using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Resumes JavaScript execution.
	/// </summary>

	[SupportedBy("IOS")]
	public class ResumeCommandParams: ICommandParams<ResumeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.Resume;
	}
}
