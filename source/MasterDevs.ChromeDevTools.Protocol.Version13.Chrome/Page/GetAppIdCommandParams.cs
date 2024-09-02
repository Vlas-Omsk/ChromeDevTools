using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Returns the unique (PWA) app id.
	/// Only returns values if the feature flag 'WebAppEnableManifestId' is enabled
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetAppIdCommandParams: ICommandParams<GetAppIdCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetAppId;
	}
}
