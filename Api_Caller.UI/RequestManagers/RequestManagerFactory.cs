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
		public IRequestManager DeleteRequestManagerInstance()
		{
			return new DeleteRequestManager(SimpleFactory.GetHttpHelperInstance());
		}

		public IRequestManager GetRequestManagerInstance()
		{
			return new GetRequestManager(SimpleFactory.GetHttpHelperInstance());
		}

		public IRequestManager PostRequestManagerInstance()
		{
			return new PostRequestManager(SimpleFactory.GetHttpHelperInstance());
		}

		public IRequestManager PutRequestManagerInstance()
		{
			return new PutRequestManager(SimpleFactory.GetHttpHelperInstance());
		}
	}
}
