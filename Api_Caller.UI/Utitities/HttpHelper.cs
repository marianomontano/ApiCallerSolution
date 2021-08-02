using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Api_Caller.UI
{
	public class HttpHelper : IHttpHelper
	{
		private readonly JsonBeautifier JsonBeautifier;
		private HttpClient Client;


		public HttpHelper(JsonBeautifier jsonBeautifier)
		{
			Client = new HttpClient();
			Client.Timeout = SimpleFactory.GetTimeSpanInstance(0, 5, 0);
			JsonBeautifier = jsonBeautifier;
		}

		public void SetClientUrl(string url)
		{
			Client.BaseAddress = new Uri(url);
		}

		public void DisposeHttpClient()
		{
			Client.Dispose();
		}

		public void SetClientHeaders(Dictionary<string, string> headers)
		{
			//Client.DefaultRequestHeaders.Clear();

			foreach (var header in headers)
			{
				Client.DefaultRequestHeaders.Add(header.Key, header.Value);
			}
		}

		public void SetAuthorizationHeader(string type, string value)
		{
			Client.DefaultRequestHeaders.Add("Authorization", $"{type} {value}");
		}

		public async Task<string> DeleteResponseAsync()
		{
			var response = await Client.DeleteAsync("");

			string responseString = await FormatResponseAsync(response);

			return responseString;
		}

		public async Task<string> GetResponseAsync()
		{
			var response = await Client.GetAsync("", HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

			string responseString = await FormatResponseAsync(response);

			return responseString;
		}

		public async Task<string> PostResponseAsync(string body)
		{
			HttpContent content = SimpleFactory.GetStringContentInstance(body);
			var response = await Client.PostAsync("", content);

			string responseString = await FormatResponseAsync(response);

			return responseString;
		}

		public async Task<string> PutResponseAsync(string body)
		{
			HttpContent content = SimpleFactory.GetStringContentInstance(body);
			var response = await Client.PutAsync("", content);

			string responseString = await FormatResponseAsync(response);

			return responseString;
		}

		private async Task<string> FormatResponseAsync(HttpResponseMessage response)
		{
			StringBuilder stringBuilder = SimpleFactory.GetStringBuilderInstance();

			stringBuilder.AppendLine("Response Status Code:");
			stringBuilder.AppendLine($"{(int)response.StatusCode} {response.ReasonPhrase} {Environment.NewLine}");

			stringBuilder.AppendLine("Response Headers:");

			foreach (var header in response.Headers)
				stringBuilder.AppendLine(header.ToString());

			var jsonBody = await response.Content.ReadAsStringAsync();
			stringBuilder.AppendLine($"{Environment.NewLine}Response Body:");

			return ParseStringToJson(stringBuilder, jsonBody);
		}

		private string ParseStringToJson(StringBuilder stringBuilder, string jsonBody)
		{
			stringBuilder.Append(JsonBeautifier.Beautify(jsonBody));
			return stringBuilder.ToString();
		}
	}
}
