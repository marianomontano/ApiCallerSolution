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
		private readonly HttpHelper httpHelper;
		private readonly SimpleFactory factory;

		public string Url { get; set; }
		public Dictionary<string, string> Parameters { get; set; }
		public Dictionary<string, string> Headers { get; set; }
		public string Response { get; set; }

		public GetRequestManager(SimpleFactory simpleFactory)
		{
			factory = simpleFactory;
			httpHelper = simpleFactory.GetHttpHelperInstance();
			Url = String.Empty;
			Parameters = simpleFactory.GetDictionaryInstance();
			Headers = simpleFactory.GetDictionaryInstance();
			Response = String.Empty;
		}

		public async Task SendRequest()
		{

			SetCompleteUrl();

			SetRequestHeaders();

			Response = await httpHelper.GetResponseAsync();

			httpHelper.DisposeHttpClient();
		}

		private void SetRequestHeaders()
		{
			if(Headers != null && Headers.Count > 0)
				httpHelper.SetClientHeaders(Headers);
		}

		private void SetCompleteUrl()
		{
			StringBuilder stringBuilder = factory.GetStringBuilderInstance();
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