using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows debug borders on layers
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowDebugBordersCommandParams: ICommandParams<SetShowDebugBordersCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowDebugBorders;
		/// <summary>
		/// True for showing debug borders
		/// </summary>
		public bool Show { get; set; }
	}
}
