using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{
	/// <summary>
	/// Overrides value returned by the javascript navigator object.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class SetNavigatorOverridesCommand: ICommand<SetNavigatorOverridesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetNavigatorOverrides;
		/// <summary>
		/// The platform navigator.platform should return.
		/// </summary>
		public string Platform { get; set; }
	}
}
