using System;
using NUnit.Framework;
using IdentityModel.Client;
using System.Net.Http;

namespace UnitTestNNCMS
{
    [TestFixture]
    public class AuthenticationTest
    {
        private readonly static string ApiUrl = "http://localhost:17167/";
        private readonly static string ClientId = "AleCms";
        private readonly static string Secret = "AleSecret";
        private readonly static string ApiName = "CmsApi";
        private readonly static string TestUrl = "http://localhost:17167/user";

        [Test]
        public void AuthenticationConnectTestMethod()
        {
            var disco = DiscoveryClient.GetAsync(ApiUrl);
            Assert.IsFalse(disco.Result.IsError);
        }

        [Test]
        public void GetAuthenticationTestMethod()
        {
            var disco = DiscoveryClient.GetAsync(ApiUrl);
            Assert.IsFalse(disco.Result.IsError);
            var tokenClient = new TokenClient(disco.Result.TokenEndpoint, ClientId,Secret);
            var tokenResponse = tokenClient.RequestClientCredentialsAsync(ApiName);
            Assert.IsTrue(tokenResponse.Result.IsError);
            var client = new HttpClient();
            client.SetBearerToken(tokenResponse.Result.AccessToken);
            var response = client.GetAsync(TestUrl);
            Assert.IsTrue(response.Result.IsSuccessStatusCode);
        }

    }
}
