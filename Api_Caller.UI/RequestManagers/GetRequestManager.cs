using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Web;
using System;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Text.Json;
using System.IO;

namespace Api_Caller.UI.RequestManagers
{
	public class GetRequestManager : IRequestManager
	{
		private readonly IHttpHelper httpHelper;

		public string Url { get; set; }
		public Dictionary<string, string> Parameters { get; set; }
		public Dictionary<string, string> Headers { get; set; }
		public Tuple<string, string> Authorization { get; set; }
		public string Response { get; set; }

		public GetRequestManager()
		{
			httpHelper = SimpleFactory.GetHttpHelperInstance();
			Url = String.Empty;
			Parameters = SimpleFactory.GetDictionaryInstance();
			Headers = SimpleFactory.GetDictionaryInstance();
			Response = String.Empty;
		}

		public GetRequestManager(IHttpHelper helper)
		{
			httpHelper = helper;
			Url = String.Empty;
			Parameters = SimpleFactory.GetDictionaryInstance();
			Headers = SimpleFactory.GetDictionaryInstance();
			Response = String.Empty;
		}

		public async Task SendRequest()
		{

			SetCompleteUrl();
			SetAuthorizationHeader();
			SetRequestHeaders();

			Response = await httpHelper.GetResponseAsync();

			//httpHelper.DisposeHttpClient();
		}

		private void SetRequestHeaders()
		{
			if(Headers != null && Headers.Count > 0)
				httpHelper.SetClientHeaders(Headers);
		}

		private void SetAuthorizationHeader()
		{
			if(Authorization != null)
				httpHelper.SetAuthorizationHeader(Authorization.Item1, Authorization.Item2);
		}

		private void SetCompleteUrl()
		{
			StringBuilder stringBuilder = SimpleFactory.GetStringBuilderInstance();
			stringBuilder.Append(Url);

			if (Parameters != null && Parameters.Count > 0)
			{
				stringBuilder.Append("?");
				foreach (var param in Parameters)
				{
					//aplico encoding sólo al parámetro, no al nombre de la variable
					stringBuilder.Append($"{param.Key}={HttpUtility.UrlEncode(param.Value, Encoding.UTF8)}&");
				}
				stringBuilder.Remove(stringBuilder.ToString().LastIndexOf('&'), 1);
			}

			//elimino el último & de la query string
			httpHelper.SetClientUrl(stringBuilder.ToString());
		}
	}
}