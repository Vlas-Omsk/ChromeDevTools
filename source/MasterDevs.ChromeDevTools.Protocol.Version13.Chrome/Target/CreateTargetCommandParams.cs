using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Creates a new page.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CreateTargetCommandParams: ICommandParams<CreateTargetCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Target.CreateTarget;
		/// <summary>
		/// The initial URL the page will be navigated to. An empty string indicates about:blank.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Frame width in DIP (headless chrome only).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Width { get; set; }
		/// <summary>
		/// Frame height in DIP (headless chrome only).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Height { get; set; }
		/// <summary>
		/// The browser context to create the page in.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
		/// <summary>
		/// Whether BeginFrames for this target will be controlled via DevTools (headless chrome only,
		/// not supported on MacOS yet, false by default).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? EnableBeginFrameControl { get; set; }
		/// <summary>
		/// Whether to create a new Window or Tab (chrome-only, false by default).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? NewWindow { get; set; }
		/// <summary>
		/// Whether to create the target in background or foreground (chrome-only,
		/// false by default).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Background { get; set; }
		/// <summary>
		/// Whether to create the target of type "tab".
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ForTab { get; set; }
	}
}
