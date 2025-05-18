using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{

	[SupportedBy("Chrome")]
	public class GetBackgroundColorsCommand: ICommand<GetBackgroundColorsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.GetBackgroundColors;
		/// <summary>
		/// Id of the node to get background colors for.
		/// </summary>
		public long NodeId { get; set; }
	}
}
