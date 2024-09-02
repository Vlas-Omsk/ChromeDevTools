using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Enables/disables issuing of sharedStorageAccessed events.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetSharedStorageTrackingCommandParams: ICommandParams<SetSharedStorageTrackingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.SetSharedStorageTracking;
		/// <summary>
		/// Enable
		/// </summary>
		public bool Enable { get; set; }
	}
}
