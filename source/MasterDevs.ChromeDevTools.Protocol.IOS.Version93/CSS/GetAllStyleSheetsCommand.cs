using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
{
	/// <summary>
	/// Returns metainfo entries for all known stylesheets.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetAllStyleSheetsCommand: ICommand<GetAllStyleSheetsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetAllStyleSheets;
	}
}
