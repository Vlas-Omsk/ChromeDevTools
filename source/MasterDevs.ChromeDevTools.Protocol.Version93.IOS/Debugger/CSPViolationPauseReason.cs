using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// The pause reason auxiliary data when paused because of a Content Security Policy directive.
	/// </summary>
	[SupportedBy("IOS")]
	public class CSPViolationPauseReason
	{
		/// <summary>
		/// The CSP directive that blocked script execution.
		/// </summary>
		public string Directive { get; set; }
	}
}
