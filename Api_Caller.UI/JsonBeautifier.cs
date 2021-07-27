using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Api_Caller.UI
{
	public class JsonBeautifier
	{
		private readonly SimpleFactory simpleFactory;
		public JsonBeautifier(SimpleFactory simpleFactory)
		{
			this.simpleFactory = simpleFactory;
		}

		public string Beautify(string json)
		{
			string result = "";
			if (json == null || json == "")
			{
				result = "{ }";
			}

			if (json.StartsWith("[") || json.StartsWith("{"))
			{
				using (var jsonDocument = JsonDocument.Parse(json))
				{
					using (var stream = simpleFactory.GetMemoryStreamInstance())
					{
						using (var writer = simpleFactory.GetUtf8JsonWriterInstance(stream))
						{
							jsonDocument.WriteTo(writer);
							writer.Flush();
							return Encoding.UTF8.GetString(stream.ToArray());
						}
					}
				}
			}

			if (!json.StartsWith("\"") && !json.EndsWith("\""))
			{
				result = "\"" + json + "\"";
			}

			return result;
		}
	}
}
