using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{
	/// <summary>
	/// Sets a specified page scale factor.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetPageScaleFactorCommand: ICommand<SetPageScaleFactorCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetPageScaleFactor;
		/// <summary>
		/// Page scale factor.
		/// </summary>
		public double PageScaleFactor { get; set; }
	}
}
