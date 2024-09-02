using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Sets attributes on element with given id. This method is useful when user edits some existing
	/// attribute value and types in several attribute name/value pairs.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAttributesAsTextCommandResult : ICommandResult
	{
	}
}
