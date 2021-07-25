using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_Caller.UI
{
	public class HttpHelper
	{
		private static HttpHelper httpHelper;
		private readonly SimpleFactory simpleFactory;
		private readonly JsonBeautifier JsonBeautifier;
		public HttpClient Client { get; }


		private HttpHelper(SimpleFactory simpleFactory)
		{
			this.simpleFactory = simpleFactory;
			Client = simpleFactory.GetHttpClientInstance();
			JsonBeautifier = simpleFactory.GetJsonBeautifierInstance();
		}

		public static HttpHelper Instance(SimpleFactory simpleFactory)
		{
				if(httpHelper == null)
				{
					httpHelper = new HttpHelper(simpleFactory);
				}

				return httpHelper;
		}

		public HttpHelper SetClientUrl(string url)
		{
			Client.BaseAddress = new Uri(url);
			return httpHelper;
		}

		public HttpHelper SetClientHeaders(Dictionary<string, string> headers)
		{
			Client.DefaultRequestHeaders.Clear();
			foreach (var header in headers)
			{
				Client.DefaultRequestHeaders.Add(header.Key, header.Value);
			}
			return httpHelper;
		}

		public async Task<string> GetResponseAsync()
		{
			var response = await Client.GetAsync("", HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

			StringBuilder stringBuilder = simpleFactory.GetStringBuilderInstance();

			stringBuilder.AppendLine("Response Status Code:");
			stringBuilder.AppendLine($"{(int)response.StatusCode} {response.ReasonPhrase} {Environment.NewLine}");

			stringBuilder.AppendLine("Response Headers:");

			foreach (var header in response.Headers)
				stringBuilder.AppendLine(header.ToString());

			var body = await response.Content.ReadAsStringAsync();
			stringBuilder.AppendLine($"{Environment.NewLine} Response Body:");

			stringBuilder.Append(JsonBeautifier.Beautify(body));
			return stringBuilder.ToString();
		}

		public async Task<string> PostResponseAsync(string body)
		{
			HttpContent content = simpleFactory.GetStringContentInstance(body);
			var response = await httpHelper.Client.PostAsync("", content);


			StringBuilder stringBuilder = simpleFactory.GetStringBuilderInstance();

			stringBuilder.AppendLine("Response Status Code:");
			stringBuilder.AppendLine($"{(int)response.StatusCode} {response.ReasonPhrase} {Environment.NewLine}");

			stringBuilder.AppendLine("Response Headers:");

			foreach (var header in response.Headers)
				stringBuilder.AppendLine(header.ToString());

			var jsonBody = await response.Content.ReadAsStringAsync();
			stringBuilder.AppendLine($"{Environment.NewLine} Response Body:");

			stringBuilder.Append(JsonBeautifier.Beautify(jsonBody));
			return stringBuilder.ToString();
		}
	}
}
