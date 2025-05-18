using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Security
{
	[SupportedBy("Chrome")]
	public class SafetyTipInfo
	{
		/// <summary>
		/// Describes whether the page triggers any safety tips or reputation warnings. Default is unknown.
		/// </summary>
		public SafetyTipStatus SafetyTipStatus { get; set; }
		/// <summary>
		/// The URL the safety tip suggested ("Did you mean?"). Only filled in for lookalike matches.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SafeUrl { get; set; }
	}
}
