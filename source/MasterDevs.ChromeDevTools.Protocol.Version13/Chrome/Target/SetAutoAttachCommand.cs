using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Controls whether to automatically attach to new targets which are considered to be related to
	/// this one. When turned on, attaches to all existing related targets as well. When turned off,
	/// automatically detaches from all currently attached targets.
	/// This also clears all targets added by `autoAttachRelated` from the list of targets to watch
	/// for creation of related targets.
	/// </summary>
	[Command(ProtocolName.Target.SetAutoAttach)]
	[SupportedBy("Chrome")]
	public class SetAutoAttachCommand: ICommandParams<SetAutoAttachCommandResponse>
	{
		/// <summary>
		/// Whether to auto-attach to related targets.
		/// </summary>
		public bool AutoAttach { get; set; }
		/// <summary>
		/// Whether to pause new targets when attaching to them. Use `Runtime.runIfWaitingForDebugger`
		/// to run paused targets.
		/// </summary>
		public bool WaitForDebuggerOnStart { get; set; }
		/// <summary>
		/// Enables "flat" access to the session via specifying sessionId attribute in the commands.
		/// We plan to make this the default, deprecate non-flattened mode,
		/// and eventually retire it. See crbug.com/991325.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Flatten { get; set; }
		/// <summary>
		/// Only targets matching filter will be attached.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FilterEntry[] Filter { get; set; }
	}
}
