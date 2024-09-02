using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Returns all supported CSS property names.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetSupportedCSSPropertiesCommandParams: ICommandParams<GetSupportedCSSPropertiesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetSupportedCSSProperties;
	}
}
