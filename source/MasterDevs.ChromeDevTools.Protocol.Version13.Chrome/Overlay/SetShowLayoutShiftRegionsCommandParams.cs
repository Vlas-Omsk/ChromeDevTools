using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows layout shift regions
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowLayoutShiftRegionsCommandParams: ICommandParams<SetShowLayoutShiftRegionsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowLayoutShiftRegions;
		/// <summary>
		/// True for showing layout shift regions
		/// </summary>
		public bool Result { get; set; }
	}
}
