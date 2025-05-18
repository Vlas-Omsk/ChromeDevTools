using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Requests that backend shows layout shift regions
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowLayoutShiftRegionsCommand: ICommand<SetShowLayoutShiftRegionsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowLayoutShiftRegions;
		/// <summary>
		/// True for showing layout shift regions
		/// </summary>
		public bool Result { get; set; }
	}
}
