using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// For Source Order Viewer testing.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetSourceOrderHighlightObjectForTestCommandParams: ICommandParams<GetSourceOrderHighlightObjectForTestCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.GetSourceOrderHighlightObjectForTest;
		/// <summary>
		/// Id of the node to highlight.
		/// </summary>
		public long NodeId { get; set; }
	}
}
