using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Animation
{
	/// <summary>
	/// Gets the remote object of the Animation.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ResolveAnimationCommandResult : ICommandResult
	{
		/// <summary>
		/// Corresponding remote object.
		/// </summary>
		public Runtime.RemoteObject RemoteObject { get; set; }
	}
}
