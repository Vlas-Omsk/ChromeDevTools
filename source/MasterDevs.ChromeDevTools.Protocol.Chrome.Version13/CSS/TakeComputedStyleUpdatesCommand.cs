using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Polls the next batch of computed style updates.
	/// </summary>

	[SupportedBy("Chrome")]
	public class TakeComputedStyleUpdatesCommand: ICommand<TakeComputedStyleUpdatesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.TakeComputedStyleUpdates;
	}
}
