using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Returns all media queries parsed by the rendering engine.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetMediaQueriesCommand: ICommand<GetMediaQueriesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetMediaQueries;
	}
}
