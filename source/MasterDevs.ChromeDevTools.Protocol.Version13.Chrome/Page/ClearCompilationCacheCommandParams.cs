using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Clears seeded compilation cache.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearCompilationCacheCommandParams: ICommandParams<ClearCompilationCacheCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.ClearCompilationCache;
	}
}
