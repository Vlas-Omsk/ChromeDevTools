using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Activates (focuses) the target.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ActivateTargetCommandParams: ICommandParams<ActivateTargetCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Target.ActivateTarget;
		/// <summary>
		/// TargetId
		/// </summary>
		public string TargetId { get; set; }
	}
}
