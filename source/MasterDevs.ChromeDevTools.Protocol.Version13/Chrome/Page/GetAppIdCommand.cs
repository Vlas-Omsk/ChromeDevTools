using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns the unique (PWA) app id.
	/// Only returns values if the feature flag 'WebAppEnableManifestId' is enabled
	/// </summary>
	[Command(ProtocolName.Page.GetAppId)]
	[SupportedBy("Chrome")]
	public class GetAppIdCommand: IProtocolCommand<GetAppIdCommandResponse>
	{
	}
}
