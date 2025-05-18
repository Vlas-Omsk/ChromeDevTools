using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Returns the unique (PWA) app id.
	/// Only returns values if the feature flag 'WebAppEnableManifestId' is enabled
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetAppIdCommand: ICommand<GetAppIdCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetAppId;
	}
}
