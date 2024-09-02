using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{

	[SupportedBy("Chrome")]
	public class SetMaxCallStackSizeToCaptureCommandParams: ICommandParams<SetMaxCallStackSizeToCaptureCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.SetMaxCallStackSizeToCapture;
		/// <summary>
		/// Size
		/// </summary>
		public long Size { get; set; }
	}
}
