using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
{
	/// <summary>
	/// Returns all supported system font family names.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetSupportedSystemFontFamilyNamesCommand: ICommand<GetSupportedSystemFontFamilyNamesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetSupportedSystemFontFamilyNames;
	}
}
