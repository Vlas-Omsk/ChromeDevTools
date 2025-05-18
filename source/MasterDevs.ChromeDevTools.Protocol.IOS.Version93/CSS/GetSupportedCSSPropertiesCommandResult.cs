using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
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
