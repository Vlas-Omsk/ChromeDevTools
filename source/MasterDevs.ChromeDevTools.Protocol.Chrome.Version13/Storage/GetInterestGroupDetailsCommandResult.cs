using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
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
