using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	[SupportedBy("Chrome")]
	public class PermissionsPolicyFeatureState
	{
		/// <summary>
		/// Feature
		/// </summary>
		public PermissionsPolicyFeature Feature { get; set; }
		/// <summary>
		/// Allowed
		/// </summary>
		public bool Allowed { get; set; }
		/// <summary>
		/// Locator
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PermissionsPolicyBlockLocator Locator { get; set; }
	}
}
