using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Sets a specified page scale factor.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetPageScaleFactorCommandParams: ICommandParams<SetPageScaleFactorCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetPageScaleFactor;
		/// <summary>
		/// Page scale factor.
		/// </summary>
		public double PageScaleFactor { get; set; }
	}
}
