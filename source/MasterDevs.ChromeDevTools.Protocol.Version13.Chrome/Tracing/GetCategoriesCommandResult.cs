using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Tracing
{
	/// <summary>
	/// Gets supported tracing categories.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCategoriesCommandResult : ICommandResult
	{
		/// <summary>
		/// A list of supported tracing categories.
		/// </summary>
		public string[] Categories { get; set; }
	}
}
