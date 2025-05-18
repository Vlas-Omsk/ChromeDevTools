using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Enables/Disables issuing of interestGroupAccessed events.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetInterestGroupTrackingCommand: ICommand<SetInterestGroupTrackingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.SetInterestGroupTracking;
		/// <summary>
		/// Enable
		/// </summary>
		public bool Enable { get; set; }
	}
}
