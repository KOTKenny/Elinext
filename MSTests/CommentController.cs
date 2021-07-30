using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System;
using System.Configuration;
using MSTests.Models;
using System.Threading.Tasks;
using System.Net;

namespace MSTests
{
    [TestClass]
    public class CommentController
    {
        private string _baseUri;
        private const string _configurationBaseUri = "baseUri";

        [TestInitialize]
        public void TestInit()
        {
            _baseUri = ConfigurationManager.AppSettings.Get(_configurationBaseUri);
        }

        [TestMethod]
        public async Task ReturnCreatedForAPost()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUri);

                Comment comment = new Comment()
                {
                    Username = "Martin",
                    Message = "This is new comment",
                    PostId = 1
                };

                HttpResponseMessage response = await client.PostAsJsonAsync("comment", comment);

                Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
            }
        }

        [TestMethod]
        public async Task ReturnConflictForAPost()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUri);

                Comment comment = new Comment()
                {
                    Username = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Quibusdam, incidunt. Aliquam obcaecati explicabo quaerat ipsa earum, doloremque nemo sed quasi! Veritatis, sint distinctio quas ducimus enim molestiae molestias dicta quibusdam.",
                    Message = "This is new comment",
                    PostId = 1
                };

                HttpResponseMessage response = await client.PostAsJsonAsync("comment", comment);

                Assert.AreEqual(response.StatusCode, 422);
            }
        }
    }
}
