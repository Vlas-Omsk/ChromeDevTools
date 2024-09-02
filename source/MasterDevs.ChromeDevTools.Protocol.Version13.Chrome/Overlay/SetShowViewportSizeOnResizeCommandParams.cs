using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Paints viewport size upon main frame resize.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowViewportSizeOnResizeCommandParams: ICommandParams<SetShowViewportSizeOnResizeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowViewportSizeOnResize;
		/// <summary>
		/// Whether to paint size or not.
		/// </summary>
		public bool Show { get; set; }
	}
}
