using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Resets the budget for `ownerOrigin` by clearing all budget withdrawals.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ResetSharedStorageBudgetCommandParams: ICommandParams<ResetSharedStorageBudgetCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.ResetSharedStorageBudget;
		/// <summary>
		/// OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
	}
}
