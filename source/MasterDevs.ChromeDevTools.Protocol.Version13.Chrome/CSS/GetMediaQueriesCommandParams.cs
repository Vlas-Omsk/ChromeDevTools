using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Returns all media queries parsed by the rendering engine.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetMediaQueriesCommandParams: ICommandParams<GetMediaQueriesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetMediaQueries;
	}
}
