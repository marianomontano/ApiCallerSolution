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

		public static JsonBeautifier GetJsonBeautifierInstance()
		{
			return new JsonBeautifier();
		}

		public static IHttpHelper GetHttpHelperInstance()
		{
			return new HttpHelper(GetJsonBeautifierInstance());
		}

		public static HttpClient GetHttpClientInstance()
		{
			return new HttpClient();
		}

		public static MemoryStream GetMemoryStreamInstance()
		{
			return new MemoryStream();
		}

		public static JsonWriterOptions GetJsonWriterOptionsInstance()
		{
			return new JsonWriterOptions { Indented = true };
		}

		public static Utf8JsonWriter GetUtf8JsonWriterInstance(Stream stream)
		{
			return new Utf8JsonWriter(stream, GetJsonWriterOptionsInstance());
		}

		public static StringBuilder GetStringBuilderInstance()
		{
			return new StringBuilder();
		}

		public static Dictionary<string, string> GetDictionaryInstance()
		{
			return new Dictionary<string, string>();
		}

		public static StringContent GetStringContentInstance(string body)
		{
			return new StringContent(body, Encoding.UTF8, "application/json");
		}

		public static TimeSpan GetTimeSpanInstance(int hours, int minutes, int seconds)
		{
			return new TimeSpan(hours, minutes, seconds);
		}
	}
}
