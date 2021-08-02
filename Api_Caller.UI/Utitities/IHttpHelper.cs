using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Caller.UI
{
	public interface IHttpHelper
	{
		void DisposeHttpClient();
		Task<string> GetResponseAsync();
		Task<string> PostResponseAsync(string body);
		Task<string> PutResponseAsync(string body);
		Task<string> DeleteResponseAsync();
		void SetAuthorizationHeader(string type, string value);
		void SetClientHeaders(Dictionary<string, string> headers);
		void SetClientUrl(string url);
	}
}