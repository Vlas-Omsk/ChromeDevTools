using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.LayerTree
{
	/// <summary>
	/// Returns the snapshot identifier.
	/// </summary>

	[SupportedBy("Chrome")]
	public class LoadSnapshotCommandParams: ICommandParams<LoadSnapshotCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.LoadSnapshot;
		/// <summary>
		/// An array of tiles composing the snapshot.
		/// </summary>
		public PictureTile[] Tiles { get; set; }
	}
}
