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
		private readonly SimpleFactory factory;
		private readonly JsonBeautifier JsonBeautifier;
		private HttpClient Client;


		public HttpHelper(SimpleFactory simpleFactory)
		{
			factory = simpleFactory;
			Client = factory.GetHttpClientInstance();
			Client.Timeout = factory.GetTimeSpanInstance(0, 5, 0);
			JsonBeautifier = factory.GetJsonBeautifierInstance();
		}

		public HttpHelper SetClientUrl(string url)
		{
			Client.BaseAddress = new Uri(url);
			return this;
		}

		public void DisposeHttpClient()
		{
			Client.Dispose();
		}

		public HttpHelper SetClientHeaders(Dictionary<string, string> headers)
		{
			Client.DefaultRequestHeaders.Clear();

			foreach (var header in headers)
			{
				Client.DefaultRequestHeaders.Add(header.Key, header.Value);
			}

			return this;
		}

		internal async Task<string> DeleteResponseAsync()
		{
			var response = await Client.DeleteAsync("");

			StringBuilder stringBuilder = factory.GetStringBuilderInstance();

			stringBuilder.AppendLine("Response Status Code:");
			stringBuilder.AppendLine($"{(int)response.StatusCode} {response.ReasonPhrase} {Environment.NewLine}");

			stringBuilder.AppendLine("Response Headers:");

			foreach (var header in response.Headers)
				stringBuilder.AppendLine(header.ToString());

			var body = await response.Content.ReadAsStringAsync();
			stringBuilder.AppendLine($"{Environment.NewLine} Response Body:");

			stringBuilder.Append(JsonBeautifier.Beautify(body));
			var responseString = stringBuilder.ToString();

			return responseString;
		}

		public async Task<string> GetResponseAsync()
		{
			var response = await Client.GetAsync("", HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

			StringBuilder stringBuilder = factory.GetStringBuilderInstance();

			stringBuilder.AppendLine("Response Status Code:");
			stringBuilder.AppendLine($"{(int)response.StatusCode} {response.ReasonPhrase} {Environment.NewLine}");

			stringBuilder.AppendLine("Response Headers:");

			foreach (var header in response.Headers)
				stringBuilder.AppendLine(header.ToString());

			var body = await response.Content.ReadAsStringAsync();
			stringBuilder.AppendLine($"{Environment.NewLine} Response Body:");

			stringBuilder.Append(JsonBeautifier.Beautify(body));
			var responseString = stringBuilder.ToString();

			return responseString;
		}

		public async Task<string> PostResponseAsync(string body)
		{
			HttpContent content = factory.GetStringContentInstance(body);
			var response = await Client.PostAsync("", content);

			StringBuilder stringBuilder = factory.GetStringBuilderInstance();

			stringBuilder.AppendLine("Response Status Code:");
			stringBuilder.AppendLine($"{(int)response.StatusCode} {response.ReasonPhrase} {Environment.NewLine}");

			stringBuilder.AppendLine("Response Headers:");

			foreach (var header in response.Headers)
				stringBuilder.AppendLine(header.ToString());

			var jsonBody = await response.Content.ReadAsStringAsync();
			stringBuilder.AppendLine($"{Environment.NewLine} Response Body:");

			stringBuilder.Append(JsonBeautifier.Beautify(jsonBody));
			var responseString = stringBuilder.ToString();

			return responseString;
		}

		public async Task<string> PutResponseAsync(string body)
		{
			HttpContent content = factory.GetStringContentInstance(body);
			var response = await Client.PutAsync("", content);

			StringBuilder stringBuilder = factory.GetStringBuilderInstance();

			stringBuilder.AppendLine("Response Status Code:");
			stringBuilder.AppendLine($"{(int)response.StatusCode} {response.ReasonPhrase} {Environment.NewLine}");

			stringBuilder.AppendLine("Response Headers:");

			foreach (var header in response.Headers)
				stringBuilder.AppendLine(header.ToString());

			var jsonBody = await response.Content.ReadAsStringAsync();
			stringBuilder.AppendLine($"{Environment.NewLine} Response Body:");

			stringBuilder.Append(JsonBeautifier.Beautify(jsonBody));
			var responseString = stringBuilder.ToString();

			return responseString;
		}
	}
}
