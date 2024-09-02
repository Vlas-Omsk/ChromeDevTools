using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Polls the next batch of computed style updates.
	/// </summary>

	[SupportedBy("Chrome")]
	public class TakeComputedStyleUpdatesCommandParams: ICommandParams<TakeComputedStyleUpdatesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.TakeComputedStyleUpdates;
	}
}
