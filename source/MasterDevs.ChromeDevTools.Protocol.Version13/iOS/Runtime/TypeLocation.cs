using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	/// Describes the location of an expression we want type information for.
	/// </summary>
	[SupportedBy("iOS")]
	public class TypeLocation
	{
		/// <summary>
		/// What kind of type information do we want (normal, function return values, 'this' statement).
		/// </summary>
		public long TypeInformationDescriptor { get; set; }
		/// <summary>
		/// sourceID uniquely identifying a script
		/// </summary>
		public string SourceID { get; set; }
		/// <summary>
		/// character offset for assignment range
		/// </summary>
		public long Divot { get; set; }
	}
}
