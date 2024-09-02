using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Set the behavior when downloading a file.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class SetDownloadBehaviorCommandParams: ICommandParams<SetDownloadBehaviorCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetDownloadBehavior;
		/// <summary>
		/// Whether to allow all or deny all download requests, or use default Chrome behavior if
		/// available (otherwise deny).
		/// </summary>
		public string Behavior { get; set; }
		/// <summary>
		/// The default path to save downloaded files to. This is required if behavior is set to 'allow'
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DownloadPath { get; set; }
	}
}
