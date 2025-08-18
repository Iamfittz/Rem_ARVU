namespace Rem_ARVU
{
	[RemObjects.SDK.Server.Service]
	[RemObjects.SDK.Server.ServiceRequiresLogin]
	public class DataService : RemObjects.DataAbstract.Server.DataAbstractService
	{
		#region Constructor/Initialize/Dispose
		public DataService()
		{
			this.InitializeComponent();
		}

		// Required for designer support
		private void InitializeComponent()
		{
			RemObjects.DataAbstract.Bin2DataStreamer dataStreamer;
			dataStreamer = new RemObjects.DataAbstract.Bin2DataStreamer();
			RemObjects.DataAbstract.Scripting.EcmaScriptProvider scriptProvider;
			scriptProvider = new RemObjects.DataAbstract.Scripting.EcmaScriptProvider();
			this.AcquireConnection = true;
			this.ServiceDataStreamer = dataStreamer;
			this.ServiceSchemaName = "Rem_ARVUDataset";
			this.ScriptProvider = scriptProvider;
		}
		#endregion
	}
}