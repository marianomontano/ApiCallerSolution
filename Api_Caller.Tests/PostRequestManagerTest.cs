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
        [Fact(Skip = "private method")]
        public void GetBodyString_ShouldReturnString()
		{
            var sut = new PostRequestManager(SimpleFactory.GetHttpHelperInstance());
            sut.Parameters.Add("id", "1");
            sut.Parameters.Add("nombre", "mariano");
            string expected = "{\"id\"=1, \"nombre\"=\"mariano\"}";

            //string actual = sut.GetBodyString();

            //Assert.Equal(expected, actual);
		}

        [Theory]
        [InlineData("{\"id\": 1, \"nombre\": \"mariano\"}", 
            "{\r\n  \"id\": 1,\r\n  \"nombre\": \"mariano\"\r\n}")]
        [InlineData("\"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwibm9tYnJlIjoiTWFyaWFubyIsImFwZWxsaWRvIjoiTW9udGFubyIsImVtYWlsIjoibW9udGFuby5tYXJpYW5vQGdtYWlsLmNvbSIsIm5iZiI6MTYyNzMxMTI4NywiZXhwIjoxNjI3MzI5Mjg3LCJpc3MiOiJ3d3cuZWR1Y2FjaW9uaXQuY29tIiwiYXVkIjoid3d3LmRvbWluaW8uY29tL2FwaS93ZWJhcGlJVCJ9.9XhmtaM1Nmw1UkQqIoPFn0PFwmYQQWx8GapleRQjd-\"",
            "\"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwibm9tYnJlIjoiTWFyaWFubyIsImFwZWxsaWRvIjoiTW9udGFubyIsImVtYWlsIjoibW9udGFuby5tYXJpYW5vQGdtYWlsLmNvbSIsIm5iZiI6MTYyNzMxMTI4NywiZXhwIjoxNjI3MzI5Mjg3LCJpc3MiOiJ3d3cuZWR1Y2FjaW9uaXQuY29tIiwiYXVkIjoid3d3LmRvbWluaW8uY29tL2FwaS93ZWJhcGlJVCJ9.9XhmtaM1Nmw1UkQqIoPFn0PFwmYQQWx8GapleRQjd-\"")]  

        public void JsonBeautifier_ShouldReturnString(string param, string expectedResult)
		{
            string token = param;
            var sut = new JsonBeautifier();

            string expected = expectedResult;

            var actual = sut.Beautify(token);

            Assert.Equal(expected, actual);
        }
    }
}
