using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Enables/Disables issuing of interestGroupAccessed events.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetInterestGroupTrackingCommandParams: ICommandParams<SetInterestGroupTrackingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.SetInterestGroupTracking;
		/// <summary>
		/// Enable
		/// </summary>
		public bool Enable { get; set; }
	}
}
