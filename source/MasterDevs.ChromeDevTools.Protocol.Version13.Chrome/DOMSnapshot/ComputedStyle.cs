using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMSnapshot
{
	/// <summary>
	/// A subset of the full ComputedStyle as defined by the request whitelist.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ComputedStyle
	{
		/// <summary>
		/// Name/value pairs of computed style properties.
		/// </summary>
		public NameValue[] Properties { get; set; }
	}
}
