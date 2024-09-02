using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Capture a snapshot of the specified node that does not include unrelated layers.
	/// </summary>

	[SupportedBy("IOS")]
	public class SnapshotNodeCommandParams: ICommandParams<SnapshotNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SnapshotNode;
		/// <summary>
		/// Id of the node to snapshot.
		/// </summary>
		public long NodeId { get; set; }
	}
}
