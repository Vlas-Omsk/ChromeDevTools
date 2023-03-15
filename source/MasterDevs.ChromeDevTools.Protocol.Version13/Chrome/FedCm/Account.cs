using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	/// <summary>
	/// Corresponds to IdentityRequestAccount
	/// </summary>
	[SupportedBy("Chrome")]
	public class Account
	{
		/// <summary>
		/// AccountId
		/// </summary>
		public string AccountId { get; set; }
		/// <summary>
		/// Email
		/// </summary>
		public string Email { get; set; }
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// GivenName
		/// </summary>
		public string GivenName { get; set; }
		/// <summary>
		/// PictureUrl
		/// </summary>
		public string PictureUrl { get; set; }
		/// <summary>
		/// IdpConfigUrl
		/// </summary>
		public string IdpConfigUrl { get; set; }
		/// <summary>
		/// IdpSigninUrl
		/// </summary>
		public string IdpSigninUrl { get; set; }
		/// <summary>
		/// LoginState
		/// </summary>
		public LoginState LoginState { get; set; }
		/// <summary>
		/// These two are only set if the loginState is signUp
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TermsOfServiceUrl { get; set; }
		/// <summary>
		/// PrivacyPolicyUrl
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PrivacyPolicyUrl { get; set; }
	}
}
