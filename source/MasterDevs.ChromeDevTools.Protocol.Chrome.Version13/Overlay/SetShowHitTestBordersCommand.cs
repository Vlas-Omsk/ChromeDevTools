using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Deprecated, no longer has any effect.
	/// </summary>
	[Obsolete("Deprecated, no longer has any effect.")]

	[SupportedBy("Chrome")]
	public class SetShowHitTestBordersCommand: ICommand<SetShowHitTestBordersCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowHitTestBorders;
		/// <summary>
		/// True for showing hit-test borders
		/// </summary>
		public bool Show { get; set; }
	}
}
