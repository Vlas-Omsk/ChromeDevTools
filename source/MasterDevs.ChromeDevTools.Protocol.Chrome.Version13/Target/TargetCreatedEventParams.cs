using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Target
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
