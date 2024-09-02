using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.LayerTree
{

	[SupportedBy("Chrome")]
	public class ProfileSnapshotCommandResult : ICommandResult
	{
		/// <summary>
		/// The array of paint profiles, one per run.
		/// </summary>
		public double[][] Timings { get; set; }
	}
}
