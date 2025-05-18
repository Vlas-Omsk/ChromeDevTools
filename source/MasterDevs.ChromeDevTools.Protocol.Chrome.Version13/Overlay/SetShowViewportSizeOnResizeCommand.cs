using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Paints viewport size upon main frame resize.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowViewportSizeOnResizeCommand: ICommand<SetShowViewportSizeOnResizeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowViewportSizeOnResize;
		/// <summary>
		/// Whether to paint size or not.
		/// </summary>
		public bool Show { get; set; }
	}
}
