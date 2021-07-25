using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api_Caller.UI.RequestManagers
{
	public interface IRequestManager
	{
		string Url { get; set; }
		Dictionary<string, string> Parameters { get; set; }
		Dictionary<string, string> Headers { get; set; }
		string Response { get; set; }
		Task SendRequest();
	}
}
