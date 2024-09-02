using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{

	[SupportedBy("Chrome")]
	public class GetBackgroundColorsCommandParams: ICommandParams<GetBackgroundColorsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetBackgroundColors;
		/// <summary>
		/// Id of the node to get background colors for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
