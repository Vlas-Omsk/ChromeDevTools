using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{
	/// <summary>
	/// Controls the visibility of compositing borders.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetCompositingBordersVisibleCommand: ICommand<SetCompositingBordersVisibleCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetCompositingBordersVisible;
		/// <summary>
		/// True for showing compositing borders.
		/// </summary>
		public bool Visible { get; set; }
	}
}
