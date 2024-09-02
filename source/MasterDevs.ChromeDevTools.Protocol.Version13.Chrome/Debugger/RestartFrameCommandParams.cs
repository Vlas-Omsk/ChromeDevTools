using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Restarts particular call frame from the beginning. The old, deprecated
	/// behavior of `restartFrame` is to stay paused and allow further CDP commands
	/// after a restart was scheduled. This can cause problems with restarting, so
	/// we now continue execution immediatly after it has been scheduled until we
	/// reach the beginning of the restarted frame.
	/// 
	/// To stay back-wards compatible, `restartFrame` now expects a `mode`
	/// parameter to be present. If the `mode` parameter is missing, `restartFrame`
	/// errors out.
	/// 
	/// The various return values are deprecated and `callFrames` is always empty.
	/// Use the call frames from the `Debugger#paused` events instead, that fires
	/// once V8 pauses at the beginning of the restarted function.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RestartFrameCommandParams: ICommandParams<RestartFrameCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.RestartFrame;
		/// <summary>
		/// Call frame identifier to evaluate on.
		/// </summary>
		public string CallFrameId { get; set; }
		/// <summary>
		/// The `mode` parameter must be present and set to 'StepInto', otherwise
		/// `restartFrame` will error out.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Mode { get; set; }
	}
}
