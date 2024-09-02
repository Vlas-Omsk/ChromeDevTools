using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.BackgroundService
{
	/// <summary>
	/// Set the recording state for the service.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetRecordingCommandParams: ICommandParams<SetRecordingCommandResult>
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
