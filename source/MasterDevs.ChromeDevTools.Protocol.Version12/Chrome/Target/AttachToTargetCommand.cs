using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Attaches to the target with given id.
	/// </summary>
	[Command(ProtocolName.Target.AttachToTarget)]
	[SupportedBy("Chrome")]
	public class AttachToTargetCommand: IProtocolCommand<AttachToTargetCommandResponse>
	{
		/// <summary>
		/// Gets or sets TargetId
		/// </summary>
		public string TargetId { get; set; }
	}
}
