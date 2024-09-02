using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Returns entries of given Map / Set collection.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetCollectionEntriesCommandResult : ICommandResult
	{
		/// <summary>
		/// Array of collection entries.
		/// </summary>
		public CollectionEntry[] Entries { get; set; }
	}
}
