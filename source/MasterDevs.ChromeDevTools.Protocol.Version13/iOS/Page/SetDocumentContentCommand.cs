using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Sets given markup as the document's HTML.
	/// </summary>
	[Command(ProtocolName.Page.SetDocumentContent)]
	[SupportedBy("iOS")]
	public class SetDocumentContentCommand: IProtocolCommand<SetDocumentContentCommandResponse>
	{
		/// <summary>
		/// Frame id to set HTML for.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// HTML content to set.
		/// </summary>
		public string Html { get; set; }
	}
}
