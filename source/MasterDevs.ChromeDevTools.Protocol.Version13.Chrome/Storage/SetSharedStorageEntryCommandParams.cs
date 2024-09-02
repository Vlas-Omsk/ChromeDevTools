using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Sets entry with `key` and `value` for a given origin's shared storage.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetSharedStorageEntryCommandParams: ICommandParams<SetSharedStorageEntryCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.SetSharedStorageEntry;
		/// <summary>
		/// OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
		/// <summary>
		/// Key
		/// </summary>
		public string Key { get; set; }
		/// <summary>
		/// Value
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// If `ignoreIfPresent` is included and true, then only sets the entry if
		/// `key` doesn't already exist.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IgnoreIfPresent { get; set; }
	}
}
