using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
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
