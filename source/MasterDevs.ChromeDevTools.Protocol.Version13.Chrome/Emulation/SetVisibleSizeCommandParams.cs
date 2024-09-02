using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Resizes the frame/viewport of the page. Note that this does not affect the frame's container
	/// (e.g. browser window). Can be used to produce screenshots of the specified size. Not supported
	/// on Android.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class SetVisibleSizeCommandParams: ICommandParams<SetVisibleSizeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetVisibleSize;
		/// <summary>
		/// Frame width (DIP).
		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Frame height (DIP).
		/// </summary>
		public long Height { get; set; }
	}
}
