using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Clears seeded compilation cache.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearCompilationCacheCommand: ICommand<ClearCompilationCacheCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.ClearCompilationCache;
	}
}
