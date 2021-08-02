using Api_Caller.UI.RequestManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Caller.UI
{
	public class RequestManagerFactory : IManagerFactory
	{
		public RequestManagerFactory()
		{
		}
		public IRequestManager DeleteRequestManagerInstance(IHttpHelper helper)
		{
			return new DeleteRequestManager(helper);
		}

		public IRequestManager GetRequestManagerInstance(IHttpHelper helper)
		{
			return new GetRequestManager(helper);
		}

		public IRequestManager PostRequestManagerInstance(IHttpHelper helper)
		{
			return new PostRequestManager(helper);
		}

		public IRequestManager PutRequestManagerInstance(IHttpHelper helper)
		{
			return new PutRequestManager(helper);
		}

		public IRequestManager GetRequestManager<T>() where T : IRequestManager, new()
		{
			return new T();
		}
	}
}
