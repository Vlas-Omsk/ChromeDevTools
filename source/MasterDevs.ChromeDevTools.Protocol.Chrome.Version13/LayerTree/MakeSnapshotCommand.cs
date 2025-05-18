using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.LayerTree
{
	/// <summary>
	/// Returns the layer snapshot identifier.
	/// </summary>

	[SupportedBy("Chrome")]
	public class MakeSnapshotCommand: ICommand<MakeSnapshotCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.MakeSnapshot;
		/// <summary>
		/// The id of the layer.
		/// </summary>
		public string LayerId { get; set; }
	}
}
