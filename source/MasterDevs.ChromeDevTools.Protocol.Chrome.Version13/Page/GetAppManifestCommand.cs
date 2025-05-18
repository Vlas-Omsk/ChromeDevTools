using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{

	[SupportedBy("Chrome")]
	public class GetAppManifestCommand: ICommand<GetAppManifestCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetAppManifest;
	}
}
