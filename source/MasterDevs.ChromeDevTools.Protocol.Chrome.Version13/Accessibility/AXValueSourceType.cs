using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Accessibility{
	/// <summary>
	/// Enum of possible property sources.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AXValueSourceType
	{
			Attribute,
			Implicit,
			Style,
			Contents,
			Placeholder,
			RelatedElement,
	}
}
