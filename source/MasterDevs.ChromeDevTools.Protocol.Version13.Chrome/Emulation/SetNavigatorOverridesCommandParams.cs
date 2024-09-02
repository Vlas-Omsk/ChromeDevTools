using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Overrides value returned by the javascript navigator object.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class SetNavigatorOverridesCommandParams: ICommandParams<SetNavigatorOverridesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetNavigatorOverrides;
		/// <summary>
		/// The platform navigator.platform should return.
		/// </summary>
		public string Platform { get; set; }
	}
}
