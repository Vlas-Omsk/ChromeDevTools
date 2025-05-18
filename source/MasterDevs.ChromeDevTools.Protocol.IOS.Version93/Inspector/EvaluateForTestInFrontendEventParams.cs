using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Inspector
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
