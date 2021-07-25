using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api_Caller.UI;
using Api_Caller.UI.RequestManagers;
using Xunit;

namespace Api_Caller.Tests
{
    public class PostRequestManagerTest
    {
        [Fact]
        public void GetBodyString_ShouldReturnString()
		{
            var sut = new PostRequestManager(SimpleFactory.Instance);
            sut.Parameters.Add("id", "1");
            sut.Parameters.Add("nombre", "mariano");
            string expected = "{\"id\"=1, \"nombre\"=\"mariano\"}";

            //string actual = sut.GetBodyString();

            //Assert.Equal(expected, actual);
		}
    }
}
