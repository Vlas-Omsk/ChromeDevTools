using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// Details for issues about documents in Quirks Mode
	/// or Limited Quirks Mode that affects page layouting.
	/// </summary>
	[SupportedBy("Chrome")]
	public class QuirksModeIssueDetails
	{
		/// <summary>
		/// If false, it means the document's mode is "quirks"
		/// instead of "limited-quirks".
		/// </summary>
		public bool IsLimitedQuirksMode { get; set; }
		/// <summary>
		/// DocumentNodeId
		/// </summary>
		public long DocumentNodeId { get; set; }
		/// <summary>
		/// Url
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// FrameId
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// LoaderId
		/// </summary>
		public string LoaderId { get; set; }
	}
}
