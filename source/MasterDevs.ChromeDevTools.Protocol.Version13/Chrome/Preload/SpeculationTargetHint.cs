using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload{
	/// <summary>
	/// Corresponds to mojom::SpeculationTargetHint.
	/// See https://github.com/WICG/nav-speculation/blob/main/triggers.md#window-name-targeting-hints
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SpeculationTargetHint
	{
			Blank,
			Self,
	}
}
