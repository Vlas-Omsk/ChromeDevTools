using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Inspector
{
	[EventName(ProtocolName.Inspector.EvaluateForTestInFrontend)]
	[SupportedBy("IOS")]
	public class EvaluateForTestInFrontendEventParams : IEventParams
	{
		/// <summary>
		/// Script
		/// </summary>
		public string Script { get; set; }
	}
}
