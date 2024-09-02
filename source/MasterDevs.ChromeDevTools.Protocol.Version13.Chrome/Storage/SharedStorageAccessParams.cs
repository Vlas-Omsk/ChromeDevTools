using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Bundles the parameters for shared storage access events whose
	/// presence/absence can vary according to SharedStorageAccessType.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SharedStorageAccessParams
	{
		/// <summary>
		/// Spec of the module script URL.
		/// Present only for SharedStorageAccessType.documentAddModule.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ScriptSourceUrl { get; set; }
		/// <summary>
		/// Name of the registered operation to be run.
		/// Present only for SharedStorageAccessType.documentRun and
		/// SharedStorageAccessType.documentSelectURL.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string OperationName { get; set; }
		/// <summary>
		/// The operation's serialized data in bytes (converted to a string).
		/// Present only for SharedStorageAccessType.documentRun and
		/// SharedStorageAccessType.documentSelectURL.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SerializedData { get; set; }
		/// <summary>
		/// Array of candidate URLs' specs, along with any associated metadata.
		/// Present only for SharedStorageAccessType.documentSelectURL.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SharedStorageUrlWithMetadata[] UrlsWithMetadata { get; set; }
		/// <summary>
		/// Key for a specific entry in an origin's shared storage.
		/// Present only for SharedStorageAccessType.documentSet,
		/// SharedStorageAccessType.documentAppend,
		/// SharedStorageAccessType.documentDelete,
		/// SharedStorageAccessType.workletSet,
		/// SharedStorageAccessType.workletAppend,
		/// SharedStorageAccessType.workletDelete, and
		/// SharedStorageAccessType.workletGet.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Key { get; set; }
		/// <summary>
		/// Value for a specific entry in an origin's shared storage.
		/// Present only for SharedStorageAccessType.documentSet,
		/// SharedStorageAccessType.documentAppend,
		/// SharedStorageAccessType.workletSet, and
		/// SharedStorageAccessType.workletAppend.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Value { get; set; }
		/// <summary>
		/// Whether or not to set an entry for a key if that key is already present.
		/// Present only for SharedStorageAccessType.documentSet and
		/// SharedStorageAccessType.workletSet.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IgnoreIfPresent { get; set; }
	}
}
