using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.LayerTree
{
	/// <summary>
	/// Replays the layer snapshot and returns canvas log.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SnapshotCommandLogCommandParams: ICommandParams<SnapshotCommandLogCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.SnapshotCommandLog;
		/// <summary>
		/// The id of the layer snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
	}
}
