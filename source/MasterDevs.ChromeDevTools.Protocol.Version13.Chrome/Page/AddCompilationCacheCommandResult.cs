using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Seeds compilation cache for given url. Compilation cache does not survive
	/// cross-process navigation.
	/// </summary>

	[SupportedBy("Chrome")]
	public class AddCompilationCacheCommandResult : ICommandResult
	{
	}
}
