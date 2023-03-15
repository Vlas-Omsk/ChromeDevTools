using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.BackgroundService
{
	/// <summary>
	/// Set the recording state for the service.
	/// </summary>
	[Command(ProtocolName.BackgroundService.SetRecording)]
	[SupportedBy("Chrome")]
	public class SetRecordingCommand: IProtocolCommand<SetRecordingCommandResponse>
	{
		/// <summary>
		/// ShouldRecord
		/// </summary>
		public bool ShouldRecord { get; set; }
		/// <summary>
		/// Service
		/// </summary>
		public string Service { get; set; }
	}
}
