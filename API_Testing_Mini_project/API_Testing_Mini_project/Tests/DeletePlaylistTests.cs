using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace API_Testing_Mini_project
{
    class DeletePlaylistTests
    {
        DeletePlaylistService _service;

        [OneTimeSetUp]
        public void Setup()
        {
            _service = new DeletePlaylistService();
            _service.MakeRequest("5RuyNWWlh2hyexZKtVTsQy");
        }

        [Category("Happy Path")]
        [Test]
        public void GivenDeletePlaylistServiceRequestMade_WhenResponseReceived_ThenResponseStatusShouldBeOk()
        {
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("OK"));
            Assert.That(_service.CallManager.StatusCode, Is.EqualTo(200));
        }

    }

    class DeletePlaylistTests_WithWrongId
    {
        DeletePlaylistService _service;

        [OneTimeSetUp]
        public void Setup()
        {
            _service = new DeletePlaylistService();
            _service.MakeRequest("WrongId");
        }

        [Category("Sad Path")]
        [Test]
        public void GivenDeletePlaylistServiceRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe404()
        {
            Assert.That(_service.JsonResponse["error"]["status"].ToString, Is.EqualTo("404"));
            Assert.That(_service.JsonResponse["error"]["message"].ToString, Is.EqualTo("Invalid playlist Id"));
        }

        class DeletePlaylistTests_WithNoId
        {
            DeletePlaylistService _service;

            [OneTimeSetUp]
            public void Setup()
            {
                _service = new DeletePlaylistService();
                _service.MakeRequest("");
            }

            [Category("Sad Path")]
            [Test]
            public void GivenDeletePlaylistServiceRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe404()
            {
                Assert.That(_service.JsonResponse["error"]["status"].ToString, Is.EqualTo("404"));
                Assert.That(_service.JsonResponse["error"]["message"].ToString, Is.EqualTo("Invalid playlist Id"));
            }
        }
    }
}
