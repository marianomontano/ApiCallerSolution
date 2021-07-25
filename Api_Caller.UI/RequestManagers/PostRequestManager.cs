using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_Caller.UI.RequestManagers
{
	public class PostRequestManager : IRequestManager
	{
		private HttpHelper httpHelper;
		private readonly SimpleFactory simpleFactory;

		public PostRequestManager(SimpleFactory simpleFactory)
		{
			this.simpleFactory = simpleFactory;
			this.httpHelper = simpleFactory.GetHttpHelperInstance();
			Parameters = simpleFactory.GetDictionaryInstance();
			Headers = simpleFactory.GetDictionaryInstance();
		}

		public string Url { get; set; }
		public Dictionary<string, string> Parameters { get; set; }
		public Dictionary<string, string> Headers { get; set; }
		public string Response { get; set; }

		public async Task SendRequest()
		{
			SetRequestHeaders();

			string body = GetBodyString();

			httpHelper.Client.BaseAddress = new Uri(Url);
			Response = await httpHelper.PostResponseAsync(body);

			httpHelper.Client.Dispose();
		}

		private void SetRequestHeaders()
		{
			if (Headers != null && Headers.Count > 0)
				httpHelper.SetClientHeaders(Headers);
		}

		private string GetBodyString()
		{
			var stringBuilder = simpleFactory.GetStringBuilderInstance();
			stringBuilder.Append("{");
			if (Parameters != null && Parameters.Count > 0)
			{
				foreach (var param in Parameters)
				{
					int value;
					if (int.TryParse(param.Value, out value))
						stringBuilder.Append($"\"{ param.Key }\": {value}, ");
					else
						stringBuilder.Append($"\"{param.Key}\": \"{param.Value}\", ");
				}

				stringBuilder.Remove(stringBuilder.ToString().LastIndexOf(','), 2);
			}
			stringBuilder.Append("}");
			
			return stringBuilder.ToString();
		}
	}
}