using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// The full details of an interest group.
	/// </summary>
	[SupportedBy("Chrome")]
	public class InterestGroupDetails
	{
		/// <summary>
		/// OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// ExpirationTime
		/// </summary>
		public double ExpirationTime { get; set; }
		/// <summary>
		/// JoiningOrigin
		/// </summary>
		public string JoiningOrigin { get; set; }
		/// <summary>
		/// BiddingUrl
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BiddingUrl { get; set; }
		/// <summary>
		/// BiddingWasmHelperUrl
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BiddingWasmHelperUrl { get; set; }
		/// <summary>
		/// UpdateUrl
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UpdateUrl { get; set; }
		/// <summary>
		/// TrustedBiddingSignalsUrl
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TrustedBiddingSignalsUrl { get; set; }
		/// <summary>
		/// TrustedBiddingSignalsKeys
		/// </summary>
		public string[] TrustedBiddingSignalsKeys { get; set; }
		/// <summary>
		/// UserBiddingSignals
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UserBiddingSignals { get; set; }
		/// <summary>
		/// Ads
		/// </summary>
		public InterestGroupAd[] Ads { get; set; }
		/// <summary>
		/// AdComponents
		/// </summary>
		public InterestGroupAd[] AdComponents { get; set; }
	}
}
