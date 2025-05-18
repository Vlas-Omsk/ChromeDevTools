using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.LayerTree
{
	/// <summary>
	/// Replays the layer snapshot and returns canvas log.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SnapshotCommandLogCommandResult : ICommandResult
	{
		public class CommandLogArray
		{
		}

		/// <summary>
		/// The array of canvas function calls.
		/// </summary>
		public CommandLogArray[] CommandLog { get; set; }
	}
}
