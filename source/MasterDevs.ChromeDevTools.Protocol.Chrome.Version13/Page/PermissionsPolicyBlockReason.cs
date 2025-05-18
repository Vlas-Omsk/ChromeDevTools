using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page{
	/// <summary>
	/// Reason for a permissions policy feature to be disabled.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PermissionsPolicyBlockReason
	{
			Header,
			IframeAttribute,
			InFencedFrameTree,
			InIsolatedApp,
	}
}
