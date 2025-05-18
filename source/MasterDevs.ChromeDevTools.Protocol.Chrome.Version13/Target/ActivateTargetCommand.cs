using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Target
{
	/// <summary>
	/// Activates (focuses) the target.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ActivateTargetCommand: ICommand<ActivateTargetCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Target.ActivateTarget;
		/// <summary>
		/// TargetId
		/// </summary>
		public string TargetId { get; set; }
	}
}
