using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Gets details for a named interest group.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetInterestGroupDetailsCommandResult : ICommandResult
	{
		/// <summary>
		/// Details
		/// </summary>
		public InterestGroupDetails Details { get; set; }
	}
}
