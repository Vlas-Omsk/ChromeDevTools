using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// CSS stylesheet metainformation.
	/// </summary>
	[SupportedBy("iOS")]
	public class CSSStyleSheetHeader
	{
		/// <summary>
		/// The stylesheet identifier.
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Owner frame identifier.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Stylesheet resource URL.
		/// </summary>
		public string SourceURL { get; set; }
		/// <summary>
		/// Stylesheet origin.
		/// </summary>
		public StyleSheetOrigin Origin { get; set; }
		/// <summary>
		/// Stylesheet title.
		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// Denotes whether the stylesheet is disabled.
		/// </summary>
		public bool Disabled { get; set; }
		/// <summary>
		/// Whether this stylesheet is a <style> tag created by the parser. This is not set for document.written <style> tags.
		/// </summary>
		public bool IsInline { get; set; }
		/// <summary>
		/// Line offset of the stylesheet within the resource (zero based).
		/// </summary>
		public double StartLine { get; set; }
		/// <summary>
		/// Column offset of the stylesheet within the resource (zero based).
		/// </summary>
		public double StartColumn { get; set; }
	}
}
