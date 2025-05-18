using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Requests that backend shows paint rectangles
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowPaintRectsCommand: ICommand<SetShowPaintRectsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowPaintRects;
		/// <summary>
		/// True for showing paint rectangles
		/// </summary>
		public bool Result { get; set; }
	}
}
