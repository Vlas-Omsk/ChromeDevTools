using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Target
{
	/// <summary>
	/// Closes the target. If the target is a page that gets closed too.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CloseTargetCommand: ICommand<CloseTargetCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Target.CloseTarget;
		/// <summary>
		/// TargetId
		/// </summary>
		public string TargetId { get; set; }
	}
}
