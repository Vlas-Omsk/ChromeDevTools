using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Navigates current page to the given URL.
	/// </summary>

	[SupportedBy("IOS")]
	public class NavigateCommandParams: ICommandParams<NavigateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.Navigate;
		/// <summary>
		/// URL to navigate the page to.
		/// </summary>
		public string Url { get; set; }
	}
}
