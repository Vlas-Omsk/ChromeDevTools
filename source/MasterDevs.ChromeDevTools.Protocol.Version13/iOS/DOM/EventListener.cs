using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// A structure holding event listener properties.
	/// </summary>
	[SupportedBy("iOS")]
	public class EventListener
	{
		/// <summary>
		/// <code>EventListener</code>'s type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// <code>EventListener</code>'s useCapture.
		/// </summary>
		public bool UseCapture { get; set; }
		/// <summary>
		/// <code>EventListener</code>'s isAttribute.
		/// </summary>
		public bool IsAttribute { get; set; }
		/// <summary>
		/// Target <code>DOMNode</code> id.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Event handler function body.
		/// </summary>
		public string HandlerBody { get; set; }
		/// <summary>
		/// Handler code location.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Debugger.Location Location { get; set; }
		/// <summary>
		/// Source script URL.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SourceName { get; set; }
		/// <summary>
		/// Event handler function value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.RemoteObject Handler { get; set; }
	}
}
