using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Worker
{
	/// <summary>
	/// Tells whether browser supports workers inspection.
	/// </summary>

	[SupportedBy("IOS")]
	public class CanInspectWorkersCommandResult : ICommandResult
	{
		/// <summary>
		/// True if browser has workers support.
		/// </summary>
		public bool Result { get; set; }
	}
}
