using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// JavaScript call frame. Array of call frames form the call stack.
	/// </summary>
	[SupportedBy("iOS")]
	public class CallFrame
	{
		/// <summary>
		/// Call frame identifier. This identifier is only valid while the virtual machine is paused.
		/// </summary>
		public string CallFrameId { get; set; }
		/// <summary>
		/// Name of the JavaScript function called on this call frame.
		/// </summary>
		public string FunctionName { get; set; }
		/// <summary>
		/// Location in the source code.
		/// </summary>
		public Location Location { get; set; }
		/// <summary>
		/// Scope chain for this call frame.
		/// </summary>
		public Scope[] ScopeChain { get; set; }
		/// <summary>
		/// <code>this</code> object for this call frame.
		/// </summary>
		public Runtime.RemoteObject This { get; set; }
	}
}
