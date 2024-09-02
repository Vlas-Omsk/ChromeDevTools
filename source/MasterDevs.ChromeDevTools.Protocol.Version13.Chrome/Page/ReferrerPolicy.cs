using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page{
	/// <summary>
	/// The referring-policy used for the navigation.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ReferrerPolicy
	{
			NoReferrer,
			NoReferrerWhenDowngrade,
			Origin,
			OriginWhenCrossOrigin,
			SameOrigin,
			StrictOrigin,
			StrictOriginWhenCrossOrigin,
			UnsafeUrl,
	}
}
