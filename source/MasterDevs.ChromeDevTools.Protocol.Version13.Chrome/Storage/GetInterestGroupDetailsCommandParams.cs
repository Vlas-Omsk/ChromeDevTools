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
	public class GetInterestGroupDetailsCommandParams: ICommandParams<GetInterestGroupDetailsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.GetInterestGroupDetails;
		/// <summary>
		/// OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }
	}
}
