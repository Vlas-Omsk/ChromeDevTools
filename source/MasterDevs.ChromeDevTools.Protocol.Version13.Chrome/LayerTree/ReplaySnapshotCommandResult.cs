using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.LayerTree
{
	/// <summary>
	/// Replays the layer snapshot and returns the resulting bitmap.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ReplaySnapshotCommandResult : ICommandResult
	{
		/// <summary>
		/// A data: URL for resulting image.
		/// </summary>
		public string DataURL { get; set; }
	}
}
