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
	public class GetCollectionEntriesCommandParams: ICommandParams<GetCollectionEntriesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.GetCollectionEntries;
		/// <summary>
		/// Id of the collection to get entries for.
		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// Symbolic group name that can be used to release multiple. If not provided, it will be the same objectGroup as the RemoteObject determined from <code>objectId</code>. This is useful for WeakMap to release the collection entries.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
		/// <summary>
		/// If provided skip to this index before collecting values. Otherwise, 0.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? StartIndex { get; set; }
		/// <summary>
		/// If provided only return <code>numberToFetch</code> values. Otherwise, return values all the way to the end.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NumberToFetch { get; set; }
	}
}