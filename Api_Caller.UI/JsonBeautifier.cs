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
			if (json == null || json == "")
			{
				return "{ }";
			}

			using (var document = JsonDocument.Parse(json))
			{
				using (var stream = simpleFactory.GetMemoryStreamInstance())
				{
					using (var writer = simpleFactory.GetUtf8JsonWriterInstance(stream))
					{
						document.WriteTo(writer);
						writer.Flush();
						return Encoding.UTF8.GetString(stream.ToArray());
					}
				}
			}
		}
	}
}
