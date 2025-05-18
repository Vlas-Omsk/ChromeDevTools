using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Sets given markup as the document's HTML.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetDocumentContentCommand: ICommand<SetDocumentContentCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetDocumentContent;
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
