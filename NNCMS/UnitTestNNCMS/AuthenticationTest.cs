using System;
using NUnit.Framework;
using IdentityModel.Client;

namespace UnitTestNNCMS
{
    [TestFixture]
    public class AuthenticationTest
    {
        private readonly static string ApiUrl = "http://localhost:17167/";

        [Test]
        public void GetAuthenticationTokenTestMethod()
        {
            var disco = DiscoveryClient.GetAsync(ApiUrl);
            Assert.IsTrue(disco.Result.IsError);
        }
    }
}
