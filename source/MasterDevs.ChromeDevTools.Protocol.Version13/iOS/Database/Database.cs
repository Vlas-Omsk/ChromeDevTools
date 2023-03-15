using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Database
{
	/// <summary>
	/// Database object.
	/// </summary>
	[SupportedBy("iOS")]
	public class Database
	{
		/// <summary>
		/// Database ID.
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Database domain.
		/// </summary>
		public string Domain { get; set; }
		/// <summary>
		/// Database name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Database version.
		/// </summary>
		public string Version { get; set; }
	}
}
