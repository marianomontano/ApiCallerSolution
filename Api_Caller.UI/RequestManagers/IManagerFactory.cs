using Api_Caller.UI.RequestManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Caller.UI
{
	public interface IManagerFactory
	{
		IRequestManager GetRequestManagerInstance(IHttpHelper helper);

		IRequestManager PostRequestManagerInstance(IHttpHelper helper);

		IRequestManager PutRequestManagerInstance(IHttpHelper helper);

		IRequestManager DeleteRequestManagerInstance(IHttpHelper helper);

		IRequestManager GetRequestManager<T>() where T : IRequestManager, new();

	}
}
