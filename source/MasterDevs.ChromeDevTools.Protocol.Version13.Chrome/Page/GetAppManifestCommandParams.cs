using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{

	[SupportedBy("Chrome")]
	public class GetAppManifestCommandParams: ICommandParams<GetAppManifestCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetAppManifest;
	}
}
