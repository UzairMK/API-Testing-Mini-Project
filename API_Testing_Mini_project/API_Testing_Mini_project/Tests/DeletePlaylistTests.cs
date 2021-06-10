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
<<<<<<< HEAD
        public async Task Setup()
        {
            _service = new DeletePlaylistService();
            await _service.MakeRequest("5RuyNWWlh2hyexZKtVTsQy");
=======
        public void Setup()
        {
            _service = new DeletePlaylistService();
            _service.MakeRequest("5RuyNWWlh2hyexZKtVTsQy");
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
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
<<<<<<< HEAD
        public async Task Setup()
        {
            _service = new DeletePlaylistService();
            await _service.MakeRequest("WrongId");
=======
        public void Setup()
        {
            _service = new DeletePlaylistService();
            _service.MakeRequest("WrongId");
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
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
<<<<<<< HEAD
            public async Task Setup()
            {
                _service = new DeletePlaylistService();
                await _service.MakeRequest("");
=======
            public void Setup()
            {
                _service = new DeletePlaylistService();
                _service.MakeRequest("");
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
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
