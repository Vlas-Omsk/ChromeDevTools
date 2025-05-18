using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Runtime
{

	[SupportedBy("Chrome")]
	public class SetMaxCallStackSizeToCaptureCommand: ICommand<SetMaxCallStackSizeToCaptureCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.SetMaxCallStackSizeToCapture;
		/// <summary>
		/// Size
		/// </summary>
		public long Size { get; set; }
	}
}
