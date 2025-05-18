using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.LayerTree
{
	/// <summary>
	/// Replays the layer snapshot and returns canvas log.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SnapshotCommandLogCommand: ICommand<SnapshotCommandLogCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.SnapshotCommandLog;
		/// <summary>
		/// The id of the layer snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
	}
}
