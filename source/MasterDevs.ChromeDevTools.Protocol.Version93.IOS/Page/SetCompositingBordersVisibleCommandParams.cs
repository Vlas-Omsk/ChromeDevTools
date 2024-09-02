using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Controls the visibility of compositing borders.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetCompositingBordersVisibleCommandParams: ICommandParams<SetCompositingBordersVisibleCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetCompositingBordersVisible;
		/// <summary>
		/// True for showing compositing borders.
		/// </summary>
		public bool Visible { get; set; }
	}
}
