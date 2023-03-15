using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// One of the interest groups was accessed by the associated page.
	/// </summary>
	[Event(ProtocolName.Storage.InterestGroupAccessed)]
	[SupportedBy("Chrome")]
	public class InterestGroupAccessedEvent
	{
		/// <summary>
		/// AccessTime
		/// </summary>
		public double AccessTime { get; set; }
		/// <summary>
		/// Type
		/// </summary>
		public InterestGroupAccessType Type { get; set; }
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
