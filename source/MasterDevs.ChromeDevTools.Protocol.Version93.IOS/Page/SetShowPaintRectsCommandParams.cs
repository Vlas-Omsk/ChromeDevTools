using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Requests that backend shows paint rectangles
	/// </summary>

	[SupportedBy("IOS")]
	public class SetShowPaintRectsCommandParams: ICommandParams<SetShowPaintRectsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetShowPaintRects;
		/// <summary>
		/// True for showing paint rectangles
		/// </summary>
		public bool Result { get; set; }
	}
}
