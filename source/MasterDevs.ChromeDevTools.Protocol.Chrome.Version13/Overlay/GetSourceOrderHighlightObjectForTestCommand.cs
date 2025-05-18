using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// For Source Order Viewer testing.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetSourceOrderHighlightObjectForTestCommand: ICommand<GetSourceOrderHighlightObjectForTestCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.GetSourceOrderHighlightObjectForTest;
		/// <summary>
		/// Id of the node to highlight.
		/// </summary>
		public long NodeId { get; set; }
	}
}
