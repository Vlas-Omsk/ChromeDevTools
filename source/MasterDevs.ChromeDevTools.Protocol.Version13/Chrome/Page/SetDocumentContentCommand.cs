using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Sets given markup as the document's HTML.
	/// </summary>
	[Command(ProtocolName.Page.SetDocumentContent)]
	[SupportedBy("Chrome")]
	public class SetDocumentContentCommand: ICommandParams<SetDocumentContentCommandResponse>
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
