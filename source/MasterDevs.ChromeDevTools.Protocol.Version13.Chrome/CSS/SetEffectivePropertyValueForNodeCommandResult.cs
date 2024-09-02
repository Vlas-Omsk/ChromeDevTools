using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Find a rule with the given active property for the given node and set the new value for this
	/// property
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetEffectivePropertyValueForNodeCommandResult : ICommandResult
	{
	}
}
