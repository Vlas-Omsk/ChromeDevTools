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
	public class LoadSnapshotCommandResult : ICommandResult
	{
		/// <summary>
		/// The id of the snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
	}
}
