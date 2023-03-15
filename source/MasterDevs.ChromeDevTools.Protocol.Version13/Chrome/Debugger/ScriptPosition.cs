using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Location in the source code.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ScriptPosition
	{
		/// <summary>
		/// LineNumber
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// ColumnNumber
		/// </summary>
		public long ColumnNumber { get; set; }
	}
}
