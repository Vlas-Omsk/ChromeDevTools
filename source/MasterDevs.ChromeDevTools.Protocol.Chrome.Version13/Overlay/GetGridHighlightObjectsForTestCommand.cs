using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// For Persistent Grid testing.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetGridHighlightObjectsForTestCommand: ICommand<GetGridHighlightObjectsForTestCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.GetGridHighlightObjectsForTest;
		/// <summary>
		/// Ids of the node to get highlight object for.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
