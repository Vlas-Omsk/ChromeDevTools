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
	public class ReplaySnapshotCommandParams: ICommandParams<ReplaySnapshotCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.ReplaySnapshot;
		/// <summary>
		/// The id of the layer snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
		/// <summary>
		/// The first step to replay from (replay from the very start if not specified).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? FromStep { get; set; }
		/// <summary>
		/// The last step to replay to (replay till the end if not specified).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ToStep { get; set; }
		/// <summary>
		/// The scale to apply while replaying (defaults to 1).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Scale { get; set; }
	}
}
