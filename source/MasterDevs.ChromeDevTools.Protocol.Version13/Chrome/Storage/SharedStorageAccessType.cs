using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage{
	/// <summary>
	/// Enum of shared storage access types.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SharedStorageAccessType
	{
			DocumentAddModule,
			DocumentSelectURL,
			DocumentRun,
			DocumentSet,
			DocumentAppend,
			DocumentDelete,
			DocumentClear,
			WorkletSet,
			WorkletAppend,
			WorkletDelete,
			WorkletClear,
			WorkletGet,
			WorkletKeys,
			WorkletEntries,
			WorkletLength,
			WorkletRemainingBudget,
	}
}
