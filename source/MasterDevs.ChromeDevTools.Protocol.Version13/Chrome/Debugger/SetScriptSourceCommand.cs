using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Edits JavaScript source live.
	/// 
	/// In general, functions that are currently on the stack can not be edited with
	/// a single exception: If the edited function is the top-most stack frame and
	/// that is the only activation of that function on the stack. In this case
	/// the live edit will be successful and a `Debugger.restartFrame` for the
	/// top-most function is automatically triggered.
	/// </summary>
	[Command(ProtocolName.Debugger.SetScriptSource)]
	[SupportedBy("Chrome")]
	public class SetScriptSourceCommand: ICommandParams<SetScriptSourceCommandResponse>
	{
		/// <summary>
		/// Id of the script to edit.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// New content of the script.
		/// </summary>
		public string ScriptSource { get; set; }
		/// <summary>
		/// If true the change will not actually be applied. Dry run may be used to get result
		/// description without actually modifying the code.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? DryRun { get; set; }
		/// <summary>
		/// If true, then `scriptSource` is allowed to change the function on top of the stack
		/// as long as the top-most stack frame is the only activation of that function.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AllowTopFrameEditing { get; set; }
	}
}
