using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{
	/// <summary>
	/// Requests that backend shows paint rectangles
	/// </summary>

	[SupportedBy("IOS")]
	public class SetShowPaintRectsCommand: ICommand<SetShowPaintRectsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetShowPaintRects;
		/// <summary>
		/// True for showing paint rectangles
		/// </summary>
		public bool Result { get; set; }
	}
}
