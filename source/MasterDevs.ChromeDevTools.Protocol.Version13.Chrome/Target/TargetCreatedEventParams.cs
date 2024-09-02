using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Issued when a possible inspection target is created.
	/// </summary>
	[EventName(ProtocolName.Target.TargetCreated)]
	[SupportedBy("Chrome")]
	public class TargetCreatedEventParams : IEventParams
	{
		/// <summary>
		/// TargetInfo
		/// </summary>
		public TargetInfo TargetInfo { get; set; }
	}
}
