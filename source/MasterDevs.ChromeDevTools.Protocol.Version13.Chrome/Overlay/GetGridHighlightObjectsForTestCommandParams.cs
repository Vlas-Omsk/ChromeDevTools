using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// For Persistent Grid testing.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetGridHighlightObjectsForTestCommandParams: ICommandParams<GetGridHighlightObjectsForTestCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.GetGridHighlightObjectsForTest;
		/// <summary>
		/// Ids of the node to get highlight object for.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
