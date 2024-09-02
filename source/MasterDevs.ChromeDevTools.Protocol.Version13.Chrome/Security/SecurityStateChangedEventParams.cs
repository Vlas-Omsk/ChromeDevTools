using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Security
{
	/// <summary>
	/// The security state of the page changed. No longer being sent.
	/// </summary>
	[EventName(ProtocolName.Security.SecurityStateChanged)]
	[SupportedBy("Chrome")]
	public class SecurityStateChangedEventParams : IEventParams
	{
		/// <summary>
		/// Security state.
		/// </summary>
		public SecurityState SecurityState { get; set; }
		/// <summary>
		/// True if the page was loaded over cryptographic transport such as HTTPS.
		/// </summary>
		public bool SchemeIsCryptographic { get; set; }
		/// <summary>
		/// Previously a list of explanations for the security state. Now always
		/// empty.
		/// </summary>
		public SecurityStateExplanation[] Explanations { get; set; }
		/// <summary>
		/// Information about insecure content on the page.
		/// </summary>
		public InsecureContentStatus InsecureContentStatus { get; set; }
		/// <summary>
		/// Overrides user-visible description of the state. Always omitted.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Summary { get; set; }
	}
}
