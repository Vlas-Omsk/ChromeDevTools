using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// WebSocket frame data.
	/// </summary>
	[SupportedBy("iOS")]
	public class WebSocketFrame
	{
		/// <summary>
		/// WebSocket frame opcode.
		/// </summary>
		public double Opcode { get; set; }
		/// <summary>
		/// WebSocket frame mask.
		/// </summary>
		public bool Mask { get; set; }
		/// <summary>
		/// WebSocket frame payload data.
		/// </summary>
		public string PayloadData { get; set; }
	}
}
