using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Closes the target. If the target is a page that gets closed too.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CloseTargetCommandParams: ICommandParams<CloseTargetCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Target.CloseTarget;
		/// <summary>
		/// TargetId
		/// </summary>
		public string TargetId { get; set; }
	}
}
