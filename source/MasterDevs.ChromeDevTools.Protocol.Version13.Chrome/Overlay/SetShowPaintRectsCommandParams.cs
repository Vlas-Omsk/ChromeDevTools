using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows paint rectangles
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowPaintRectsCommandParams: ICommandParams<SetShowPaintRectsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowPaintRects;
		/// <summary>
		/// True for showing paint rectangles
		/// </summary>
		public bool Result { get; set; }
	}
}
