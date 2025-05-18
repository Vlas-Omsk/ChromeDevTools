using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Runtime
{
	/// <summary>
	/// Range of an error in source code.
	/// </summary>
	[SupportedBy("IOS")]
	public class ErrorRange
	{
		/// <summary>
		/// Start offset of range (inclusive).
		/// </summary>
		public long StartOffset { get; set; }
		/// <summary>
		/// End offset of range (exclusive).
		/// </summary>
		public long EndOffset { get; set; }
	}
}
