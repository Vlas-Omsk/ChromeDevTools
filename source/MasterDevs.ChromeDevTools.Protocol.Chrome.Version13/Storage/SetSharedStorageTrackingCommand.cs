using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Enables/disables issuing of sharedStorageAccessed events.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetSharedStorageTrackingCommand: ICommand<SetSharedStorageTrackingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.SetSharedStorageTracking;
		/// <summary>
		/// Enable
		/// </summary>
		public bool Enable { get; set; }
	}
}
