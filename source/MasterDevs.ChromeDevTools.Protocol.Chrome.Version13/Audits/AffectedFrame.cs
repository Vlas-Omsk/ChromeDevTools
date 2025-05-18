using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Audits
{
	/// <summary>
	/// Information about the frame affected by an inspector issue.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AffectedFrame
	{
		/// <summary>
		/// FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}
