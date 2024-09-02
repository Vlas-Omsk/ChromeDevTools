using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Security
{
	/// <summary>
	/// An explanation of an factor contributing to the security state.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SecurityStateExplanation
	{
		/// <summary>
		/// Security state representing the severity of the factor being explained.
		/// </summary>
		public SecurityState SecurityState { get; set; }
		/// <summary>
		/// Title describing the type of factor.
		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// Short phrase describing the type of factor.
		/// </summary>
		public string Summary { get; set; }
		/// <summary>
		/// Full text explanation of the factor.
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// The type of mixed content described by the explanation.
		/// </summary>
		public MixedContentType MixedContentType { get; set; }
		/// <summary>
		/// Page certificate.
		/// </summary>
		public string[] Certificate { get; set; }
		/// <summary>
		/// Recommendations to fix any issues.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Recommendations { get; set; }
	}
}
