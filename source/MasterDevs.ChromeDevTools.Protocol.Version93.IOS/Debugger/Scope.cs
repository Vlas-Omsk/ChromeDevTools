using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Scope description.
	/// </summary>
	[SupportedBy("IOS")]
	public class Scope
	{
		/// <summary>
		/// Scope type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Object representing the scope. For <code>global</code> and <code>with</code> scopes it represents the actual object; for the rest of the scopes, it is artificial transient object enumerating scope variables as its properties.
		/// </summary>
		public Runtime.RemoteObject Object { get; set; }
	}
}
