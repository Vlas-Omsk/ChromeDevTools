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
	public class MakeSnapshotCommandResult : ICommandResult
	{
		/// <summary>
		/// The id of the layer snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
	}
}
