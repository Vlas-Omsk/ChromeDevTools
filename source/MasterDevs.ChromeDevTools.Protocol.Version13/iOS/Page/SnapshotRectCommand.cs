using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Capture a snapshot of the page within the specified rectangle and coordinate system.
	/// </summary>
	[Command(ProtocolName.Page.SnapshotRect)]
	[SupportedBy("iOS")]
	public class SnapshotRectCommand: IProtocolCommand<SnapshotRectCommandResponse>
	{
		/// <summary>
		/// X coordinate
		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// Y coordinate
		/// </summary>
		public long Y { get; set; }
		/// <summary>
		/// Rectangle width
		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Rectangle height
		/// </summary>
		public long Height { get; set; }
		/// <summary>
		/// Indicates the coordinate system of the supplied rectangle.
		/// </summary>
		public string CoordinateSystem { get; set; }
	}
}
