using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Database
{
	/// <summary>
	/// Database error.
	/// </summary>
	[SupportedBy("IOS")]
	public class Error
	{
		/// <summary>
		/// Error message.
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Error code.
		/// </summary>
		public long Code { get; set; }
	}
}
