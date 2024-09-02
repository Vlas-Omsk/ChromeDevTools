using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.LayerTree
{
	/// <summary>
	/// Releases layer snapshot captured by the back-end.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ReleaseSnapshotCommandParams: ICommandParams<ReleaseSnapshotCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.ReleaseSnapshot;
		/// <summary>
		/// The id of the layer snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
	}
}
