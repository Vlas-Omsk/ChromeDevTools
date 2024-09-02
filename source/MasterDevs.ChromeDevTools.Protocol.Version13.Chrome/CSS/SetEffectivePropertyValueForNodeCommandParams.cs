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
	public class SetEffectivePropertyValueForNodeCommandParams: ICommandParams<SetEffectivePropertyValueForNodeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.SetEffectivePropertyValueForNode;
		/// <summary>
		/// The element id for which to set property.
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// PropertyName
		/// </summary>
		public string PropertyName { get; set; }
		/// <summary>
		/// Value
		/// </summary>
		public string Value { get; set; }
	}
}
