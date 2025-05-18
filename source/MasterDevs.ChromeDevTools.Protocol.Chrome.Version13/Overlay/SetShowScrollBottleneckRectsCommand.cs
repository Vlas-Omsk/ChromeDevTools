using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Requests that backend shows scroll bottleneck rects
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowScrollBottleneckRectsCommand: ICommand<SetShowScrollBottleneckRectsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowScrollBottleneckRects;
		/// <summary>
		/// True for showing scroll bottleneck rects
		/// </summary>
		public bool Show { get; set; }
	}
}
