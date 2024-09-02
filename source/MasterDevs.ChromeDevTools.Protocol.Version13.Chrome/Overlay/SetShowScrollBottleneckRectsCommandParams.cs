using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows scroll bottleneck rects
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowScrollBottleneckRectsCommandParams: ICommandParams<SetShowScrollBottleneckRectsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowScrollBottleneckRects;
		/// <summary>
		/// True for showing scroll bottleneck rects
		/// </summary>
		public bool Show { get; set; }
	}
}
