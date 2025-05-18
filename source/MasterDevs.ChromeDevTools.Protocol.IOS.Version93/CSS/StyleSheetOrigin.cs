using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS{
	/// <summary>
	/// Stylesheet type: "user" for user stylesheets, "user-agent" for user-agent stylesheets, "inspector" for stylesheets created by the inspector (i.e. those holding the "via inspector" rules), "regular" for regular stylesheets.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum StyleSheetOrigin
	{
			User,
			[EnumMember(Value = "user-agent")]
			User_agent,
			Inspector,
			Regular,
	}
}
