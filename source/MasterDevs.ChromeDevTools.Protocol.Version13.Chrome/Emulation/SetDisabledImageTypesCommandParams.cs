using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{

	[SupportedBy("Chrome")]
	public class SetDisabledImageTypesCommandParams: ICommandParams<SetDisabledImageTypesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetDisabledImageTypes;
		/// <summary>
		/// Image types to disable.
		/// </summary>
		public string[] ImageTypes { get; set; }
	}
}
