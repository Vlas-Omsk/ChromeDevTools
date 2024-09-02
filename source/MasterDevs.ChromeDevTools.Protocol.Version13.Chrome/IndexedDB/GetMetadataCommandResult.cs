using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.IndexedDB
{
	/// <summary>
	/// Gets metadata of an object store.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetMetadataCommandResult : ICommandResult
	{
		/// <summary>
		/// the entries count
		/// </summary>
		public double EntriesCount { get; set; }
		/// <summary>
		/// the current value of key generator, to become the next inserted
		/// key into the object store. Valid if objectStore.autoIncrement
		/// is true.
		/// </summary>
		public double KeyGeneratorValue { get; set; }
	}
}
