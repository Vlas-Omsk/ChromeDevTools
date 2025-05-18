using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Returns NodeIds of current top layer elements.
	/// Top layer is rendered closest to the user within a viewport, therefore its elements always
	/// appear on top of all other content.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetTopLayerElementsCommand: ICommand<GetTopLayerElementsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.GetTopLayerElements;
	}
}
