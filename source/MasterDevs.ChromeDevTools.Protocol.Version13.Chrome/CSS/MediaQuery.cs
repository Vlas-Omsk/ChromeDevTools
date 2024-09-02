using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Media query descriptor.
	/// </summary>
	[SupportedBy("Chrome")]
	public class MediaQuery
	{
		/// <summary>
		/// Array of media query expressions.
		/// </summary>
		public MediaQueryExpression[] Expressions { get; set; }
		/// <summary>
		/// Whether the media query condition is satisfied.
		/// </summary>
		public bool Active { get; set; }
	}
}
