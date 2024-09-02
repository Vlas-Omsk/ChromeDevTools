using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Audits
{
	[SupportedBy("Chrome")]
	public class LowTextContrastIssueDetails
	{
		/// <summary>
		/// ViolatingNodeId
		/// </summary>
		public long ViolatingNodeId { get; set; }
		/// <summary>
		/// ViolatingNodeSelector
		/// </summary>
		public string ViolatingNodeSelector { get; set; }
		/// <summary>
		/// ContrastRatio
		/// </summary>
		public double ContrastRatio { get; set; }
		/// <summary>
		/// ThresholdAA
		/// </summary>
		public double ThresholdAA { get; set; }
		/// <summary>
		/// ThresholdAAA
		/// </summary>
		public double ThresholdAAA { get; set; }
		/// <summary>
		/// FontSize
		/// </summary>
		public string FontSize { get; set; }
		/// <summary>
		/// FontWeight
		/// </summary>
		public string FontWeight { get; set; }
	}
}
