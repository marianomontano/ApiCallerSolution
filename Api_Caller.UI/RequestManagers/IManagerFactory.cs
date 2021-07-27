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
		IRequestManager GetRequestManagerInstance();

		IRequestManager PostRequestManagerInstance();

		IRequestManager PutRequestManagerInstance();

		IRequestManager DeleteRequestManagerInstance();

	}
}
