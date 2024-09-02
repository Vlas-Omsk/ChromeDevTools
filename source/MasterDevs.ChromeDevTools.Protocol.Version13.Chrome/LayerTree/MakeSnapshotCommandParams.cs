using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.LayerTree
{
	/// <summary>
	/// Returns the layer snapshot identifier.
	/// </summary>

	[SupportedBy("Chrome")]
	public class MakeSnapshotCommandParams: ICommandParams<MakeSnapshotCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.MakeSnapshot;
		/// <summary>
		/// The id of the layer.
		/// </summary>
		public string LayerId { get; set; }
	}
}
