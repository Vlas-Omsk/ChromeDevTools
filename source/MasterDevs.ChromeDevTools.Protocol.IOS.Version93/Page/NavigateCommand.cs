using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{
	/// <summary>
	/// Navigates current page to the given URL.
	/// </summary>

	[SupportedBy("IOS")]
	public class NavigateCommand: ICommand<NavigateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.Navigate;
		/// <summary>
		/// URL to navigate the page to.
		/// </summary>
		public string Url { get; set; }
	}
}
