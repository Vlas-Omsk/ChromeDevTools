using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[SupportedBy("Chrome")]
	public class BackForwardCacheNotRestoredExplanationTree
	{
		/// <summary>
		/// URL of each frame
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Not restored reasons of each frame
		/// </summary>
		public BackForwardCacheNotRestoredExplanation[] Explanations { get; set; }
		/// <summary>
		/// Array of children frame
		/// </summary>
		public BackForwardCacheNotRestoredExplanationTree[] Children { get; set; }
	}
}
