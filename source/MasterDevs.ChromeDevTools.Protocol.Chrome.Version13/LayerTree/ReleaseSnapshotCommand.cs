using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.LayerTree
{
	/// <summary>
	/// Releases layer snapshot captured by the back-end.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ReleaseSnapshotCommand: ICommand<ReleaseSnapshotCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.ReleaseSnapshot;
		/// <summary>
		/// The id of the layer snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
	}
}
