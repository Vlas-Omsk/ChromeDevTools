using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	/// <summary>
	/// Makes backend skip steps in the script in blackboxed ranges. VM will try leave blacklisted
	/// scripts by performing 'step in' several times, finally resorting to 'step out' if unsuccessful.
	/// Positions array contains positions where blackbox state is changed. First interval isn't
	/// blackboxed. Array should be sorted.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBlackboxedRangesCommandResult : ICommandResult
	{
	}
}
