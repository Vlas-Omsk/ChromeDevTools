using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Adds the specified target to the list of targets that will be monitored for any related target
	/// creation (such as child frames, child workers and new versions of service worker) and reported
	/// through `attachedToTarget`. The specified target is also auto-attached.
	/// This cancels the effect of any previous `setAutoAttach` and is also cancelled by subsequent
	/// `setAutoAttach`. Only available at the Browser target.
	/// </summary>

	[SupportedBy("Chrome")]
	public class AutoAttachRelatedCommandResult : ICommandResult
	{
	}
}
