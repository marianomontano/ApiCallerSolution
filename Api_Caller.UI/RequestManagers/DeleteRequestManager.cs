using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Caller.UI.RequestManagers
{
	public class DeleteRequestManager : IRequestManager
	{
		private HttpHelper httpHelper;
		private readonly SimpleFactory factory;

		public DeleteRequestManager(SimpleFactory simpleFactory)
		{
			factory = simpleFactory;
			httpHelper = simpleFactory.GetHttpHelperInstance();
			Parameters = factory.GetDictionaryInstance();
			Headers = factory.GetDictionaryInstance();
		}

		public string Url { get; set; }
		public Dictionary<string, string> Parameters { get; set; }
		public Dictionary<string, string> Headers { get; set; }
		public string Response { get; set; }

		public async Task SendRequest()
		{
			SetRequestHeaders();

			httpHelper.SetClientUrl(Url);
			Response = await httpHelper.DeleteResponseAsync();

			httpHelper.DisposeHttpClient();
		}

		private void SetRequestHeaders()
		{
			if (Headers != null && Headers.Count > 0)
				httpHelper.SetClientHeaders(Headers);
		}
	}
}