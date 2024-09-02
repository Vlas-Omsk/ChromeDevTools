using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.LayerTree
{

	[SupportedBy("Chrome")]
	public class ProfileSnapshotCommandParams: ICommandParams<ProfileSnapshotCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.ProfileSnapshot;
		/// <summary>
		/// The id of the layer snapshot.
		/// </summary>
		public string SnapshotId { get; set; }
		/// <summary>
		/// The maximum number of times to replay the snapshot (1, if not specified).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MinRepeatCount { get; set; }
		/// <summary>
		/// The minimum duration (in seconds) to replay the snapshot.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double MinDuration { get; set; }
		/// <summary>
		/// The clip rectangle to apply when replaying the snapshot.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.Rect ClipRect { get; set; }
	}
}
