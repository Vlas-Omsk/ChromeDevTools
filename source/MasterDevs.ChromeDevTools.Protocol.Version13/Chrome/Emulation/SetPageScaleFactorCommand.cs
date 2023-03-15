using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Sets a specified page scale factor.
	/// </summary>
	[Command(ProtocolName.Emulation.SetPageScaleFactor)]
	[SupportedBy("Chrome")]
	public class SetPageScaleFactorCommand: IProtocolCommand<SetPageScaleFactorCommandResponse>
	{
		/// <summary>
		/// Page scale factor.
		/// </summary>
		public double PageScaleFactor { get; set; }
	}
}
