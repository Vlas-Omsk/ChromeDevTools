using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	[SupportedBy("Chrome")]
	public class CorsErrorStatus
	{
		/// <summary>
		/// CorsError
		/// </summary>
		public CorsError CorsError { get; set; }
		/// <summary>
		/// FailedParameter
		/// </summary>
		public string FailedParameter { get; set; }
	}
}
