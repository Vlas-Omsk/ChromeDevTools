using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Returns stylesheet data for the specified <code>styleSheetId</code>.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetStyleSheetCommandResult : ICommandResult
	{
		/// <summary>
		/// Stylesheet contents for the specified <code>styleSheetId</code>.
		/// </summary>
		public CSSStyleSheetBody StyleSheet { get; set; }
	}
}
