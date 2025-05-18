using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page{
	/// <summary>
	/// Enum of possible auto-reponse for permisison / prompt dialogs.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutoResponseMode
	{
			None,
			AutoAccept,
			AutoReject,
			AutoOptOut,
	}
}
