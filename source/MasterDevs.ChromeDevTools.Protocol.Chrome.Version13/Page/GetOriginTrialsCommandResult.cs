using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Get Origin Trials on given frame.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetOriginTrialsCommandResult : ICommandResult
	{
		/// <summary>
		/// OriginTrials
		/// </summary>
		public OriginTrial[] OriginTrials { get; set; }
	}
}
