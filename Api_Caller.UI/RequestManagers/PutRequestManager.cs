using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Caller.UI.RequestManagers
{
	public class PutRequestManager : IRequestManager
	{
		private HttpHelper httpHelper;
		private readonly SimpleFactory simpleFactory;

		public PutRequestManager(SimpleFactory simpleFactory)
		{
			this.simpleFactory = simpleFactory;
			this.httpHelper = simpleFactory.GetHttpHelperInstance();
		}

		public string Url { get; set; }
		public Dictionary<string, string> Parameters { get; set; }
		public Dictionary<string, string> Headers { get; set; }
		public string Response { get; set; }

		public async Task SendRequest()
		{
			throw new System.NotImplementedException();
		}
	}
}