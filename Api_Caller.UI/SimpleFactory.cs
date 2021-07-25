using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Api_Caller.UI.RequestManagers;

namespace Api_Caller.UI
{
	public class SimpleFactory
	{
		private static SimpleFactory simpleFactory;

		private SimpleFactory()
		{

		}

		public static SimpleFactory Instance
		{
			get
			{
				if (simpleFactory == null)
				{
					simpleFactory = new SimpleFactory();
				}

				return simpleFactory;
			}
		}

		public GetRequestManager GetRequestManagerInstance()
		{
			return new GetRequestManager(Instance);
		}

		public PostRequestManager GetPostRequestManagerInstance()
		{
			return new PostRequestManager(Instance);
		}

		public PutRequestManager GetPutRequestManagerInstance()
		{
			return new PutRequestManager(Instance);
		}

		public DeleteRequestManager GetDeleteRequestManagerInstance()
		{
			return new DeleteRequestManager(Instance);
		}

		public JsonBeautifier GetJsonBeautifierInstance()
		{
			return new JsonBeautifier(Instance);
		}

		public HttpHelper GetHttpHelperInstance()
		{
			return new HttpHelper(Instance);
		}

		public HttpClient GetHttpClientInstance()
		{
			return new HttpClient();
		}

		public MemoryStream GetMemoryStreamInstance()
		{
			return new MemoryStream();
		}

		public JsonWriterOptions GetJsonWriterOptionsInstance()
		{
			return new JsonWriterOptions { Indented = true };
		}

		public Utf8JsonWriter GetUtf8JsonWriterInstance(Stream stream)
		{
			return new Utf8JsonWriter(stream, GetJsonWriterOptionsInstance());
		}

		public StringBuilder GetStringBuilderInstance()
		{
			return new StringBuilder();
		}

		public Dictionary<string, string> GetDictionaryInstance()
		{
			return new Dictionary<string, string>();
		}

		public StringContent GetStringContentInstance(string body)
		{
			return new StringContent(body, Encoding.UTF8, "application/json");
		}

		public TimeSpan GetTimeSpanInstance(int hours, int minutes, int seconds)
		{
			return new TimeSpan(hours, minutes, seconds);
		}
	}
}
