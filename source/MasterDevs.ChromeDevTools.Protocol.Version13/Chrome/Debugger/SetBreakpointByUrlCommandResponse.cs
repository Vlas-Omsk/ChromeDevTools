using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Sets JavaScript breakpoint at given location specified either by URL or URL regex. Once this
	/// command is issued, all existing parsed scripts will have breakpoints resolved and returned in
	/// `locations` property. Further matching script parsing will result in subsequent
	/// `breakpointResolved` events issued. This logical breakpoint will survive page reloads.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetBreakpointByUrl)]
	[SupportedBy("Chrome")]
	public class SetBreakpointByUrlCommandResponse
	{
		/// <summary>
		/// Id of the created breakpoint for further reference.
		/// </summary>
		public string BreakpointId { get; set; }
		/// <summary>
		/// List of the locations this breakpoint resolved into upon addition.
		/// </summary>
		public Location[] Locations { get; set; }
	}
}
