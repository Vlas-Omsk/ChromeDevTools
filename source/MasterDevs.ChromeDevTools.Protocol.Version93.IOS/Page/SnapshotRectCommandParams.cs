using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Capture a snapshot of the page within the specified rectangle and coordinate system.
	/// </summary>

	[SupportedBy("IOS")]
	public class SnapshotRectCommandParams: ICommandParams<SnapshotRectCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SnapshotRect;
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
