using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Requests that backend shows debug borders on layers
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowDebugBordersCommand: ICommand<SetShowDebugBordersCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowDebugBorders;
		/// <summary>
		/// True for showing debug borders
		/// </summary>
		public bool Show { get; set; }
	}
}
