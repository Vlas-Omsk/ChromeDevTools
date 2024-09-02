using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Sets given markup as the document's HTML.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetDocumentContentCommandParams: ICommandParams<SetDocumentContentCommandResult>
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
