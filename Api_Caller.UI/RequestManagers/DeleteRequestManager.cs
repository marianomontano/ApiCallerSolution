using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Caller.UI.RequestManagers
{
	public class DeleteRequestManager : IRequestManager
	{
		private HttpHelper httpHelper;

		public DeleteRequestManager(HttpHelper helper)
		{
			httpHelper = helper;
			Parameters = SimpleFactory.GetDictionaryInstance();
			Headers = SimpleFactory.GetDictionaryInstance();
		}

		public string Url { get; set; }
		public Dictionary<string, string> Parameters { get; set; }
		public Dictionary<string, string> Headers { get; set; }
		public string Response { get; set; }
		public Tuple<string, string> Authorization { get; set; }

		public async Task SendRequest()
		{
			httpHelper.SetClientUrl(Url);
			SetRequestHeaders();
			SetAuthorizationHeader();

			Response = await httpHelper.DeleteResponseAsync();

			//httpHelper.DisposeHttpClient();
		}

		private void SetRequestHeaders()
		{
			if (Headers != null && Headers.Count > 0)
				httpHelper.SetClientHeaders(Headers);
		}

		private void SetAuthorizationHeader()
		{
			if (Authorization != null)
				httpHelper.SetAuthorizationHeader(Authorization.Item1, Authorization.Item2);
		}
	}
}