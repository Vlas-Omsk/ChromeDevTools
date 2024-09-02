using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Description of an isolated world.
	/// </summary>
	[SupportedBy("IOS")]
	public class ExecutionContextDescription
	{
		/// <summary>
		/// Unique id of the execution context. It can be used to specify in which execution context script evaluation should be performed.
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// True if this is a context where inpspected web page scripts run. False if it is a content script isolated context.
		/// </summary>
		public bool IsPageContext { get; set; }
		/// <summary>
		/// Human readable name describing given context.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Id of the owning frame.
		/// </summary>
		public string FrameId { get; set; }
	}
}
