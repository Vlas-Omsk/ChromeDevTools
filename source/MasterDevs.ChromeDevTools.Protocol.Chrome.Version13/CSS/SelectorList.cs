using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Selector list data.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SelectorList
	{
		/// <summary>
		/// Selectors in the list.
		/// </summary>
		public Value[] Selectors { get; set; }
		/// <summary>
		/// Rule selector text.
		/// </summary>
		public string Text { get; set; }
	}
}
