using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.BackgroundService
{
	/// <summary>
	/// Set the recording state for the service.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetRecordingCommand: ICommand<SetRecordingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.BackgroundService.SetRecording;
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
