using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Enables target discovery for the specified locations, when `setDiscoverTargets` was set to
	/// `true`.
	/// </summary>
	[Command(ProtocolName.Target.SetRemoteLocations)]
	[SupportedBy("Chrome")]
	public class SetRemoteLocationsCommand: IProtocolCommand<SetRemoteLocationsCommandResponse>
	{
		/// <summary>
		/// List of remote locations.
		/// </summary>
		public RemoteLocation[] Locations { get; set; }
	}
}
