using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	[Command(ProtocolName.Runtime.SetMaxCallStackSizeToCapture)]
	[SupportedBy("Chrome")]
	public class SetMaxCallStackSizeToCaptureCommand: IProtocolCommand<SetMaxCallStackSizeToCaptureCommandResponse>
	{
		/// <summary>
		/// Size
		/// </summary>
		public long Size { get; set; }
	}
}
