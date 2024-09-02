using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Tells whether emulation is supported.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CanEmulateCommandResult : ICommandResult
	{
		/// <summary>
		/// True if emulation is supported.
		/// </summary>
		public bool Result { get; set; }
	}
}
