using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Deprecated, no longer has any effect.
	/// </summary>
	[Obsolete("Deprecated, no longer has any effect.")]

	[SupportedBy("Chrome")]
	public class SetShowHitTestBordersCommandParams: ICommandParams<SetShowHitTestBordersCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowHitTestBorders;
		/// <summary>
		/// True for showing hit-test borders
		/// </summary>
		public bool Show { get; set; }
	}
}
