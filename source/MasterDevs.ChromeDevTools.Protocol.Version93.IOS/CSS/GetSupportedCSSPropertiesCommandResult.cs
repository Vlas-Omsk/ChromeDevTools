using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Returns all supported CSS property names.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetSupportedCSSPropertiesCommandResult : ICommandResult
	{
		/// <summary>
		/// Supported property metainfo.
		/// </summary>
		public CSSPropertyInfo[] CssProperties { get; set; }
	}
}
