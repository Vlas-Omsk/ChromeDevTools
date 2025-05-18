using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Resets the budget for `ownerOrigin` by clearing all budget withdrawals.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ResetSharedStorageBudgetCommandResult : ICommandResult
	{
	}
}
