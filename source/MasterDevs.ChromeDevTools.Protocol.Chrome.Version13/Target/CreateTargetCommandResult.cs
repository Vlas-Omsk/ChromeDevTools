using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Target
{
	/// <summary>
	/// Creates a new page.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CreateTargetCommandResult : ICommandResult
	{
		/// <summary>
		/// The id of the page opened.
		/// </summary>
		public string TargetId { get; set; }
	}
}
