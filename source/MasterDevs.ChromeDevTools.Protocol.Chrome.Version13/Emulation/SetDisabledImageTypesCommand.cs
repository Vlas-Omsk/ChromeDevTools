using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{

	[SupportedBy("Chrome")]
	public class SetDisabledImageTypesCommand: ICommand<SetDisabledImageTypesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetDisabledImageTypes;
		/// <summary>
		/// Image types to disable.
		/// </summary>
		public string[] ImageTypes { get; set; }
	}
}
