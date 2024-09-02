using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
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
