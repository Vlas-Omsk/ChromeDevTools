using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Tracing
{
	/// <summary>
	/// Gets supported tracing categories.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetCategoriesCommand: ICommand<GetCategoriesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Tracing.GetCategories;
	}
}
