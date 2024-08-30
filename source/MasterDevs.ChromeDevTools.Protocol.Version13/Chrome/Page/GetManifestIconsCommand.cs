using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Deprecated because it's not guaranteed that the returned icon is in fact the one used for PWA installation.
	/// </summary>
	[Obsolete("Deprecated because it's not guaranteed that the returned icon is in fact the one used for PWA installation.")]
	[Command(ProtocolName.Page.GetManifestIcons)]
	[SupportedBy("Chrome")]
	public class GetManifestIconsCommand: ICommandParams<GetManifestIconsCommandResponse>
	{
	}
}
