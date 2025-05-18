using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Log
{
	/// <summary>
	/// Violation configuration setting.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ViolationSetting
	{
		/// <summary>
		/// Violation type.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Time threshold to trigger upon.
		/// </summary>
		public double Threshold { get; set; }
	}
}
