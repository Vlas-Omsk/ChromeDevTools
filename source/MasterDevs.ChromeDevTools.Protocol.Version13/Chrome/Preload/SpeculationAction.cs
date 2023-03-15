using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload{
	/// <summary>
	/// The type of preloading attempted. It corresponds to
	/// mojom::SpeculationAction (although PrefetchWithSubresources is omitted as it
	/// isn't being used by clients).
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SpeculationAction
	{
			Prefetch,
			Prerender,
	}
}
