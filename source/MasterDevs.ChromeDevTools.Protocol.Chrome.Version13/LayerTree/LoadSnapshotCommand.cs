using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.LayerTree
{
	/// <summary>
	/// Returns the snapshot identifier.
	/// </summary>

	[SupportedBy("Chrome")]
	public class LoadSnapshotCommand: ICommand<LoadSnapshotCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.LoadSnapshot;
		/// <summary>
		/// An array of tiles composing the snapshot.
		/// </summary>
		public PictureTile[] Tiles { get; set; }
	}
}
