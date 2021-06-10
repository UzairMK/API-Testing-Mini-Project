using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace API_Testing_Mini_project
{
    class PostCreatePlaylistTests
    {
        PostCreatePlaylistService _service;

        [OneTimeSetUp]
        public async Task Setup()
        {
            _service = new PostCreatePlaylistService();
            await _service.MakeRequest("ghastlykid");
        }

        [Category("Happy Path")]
        [Test]
        public void PostCreatePlaylistServiceRequestMade_WhenResponseReceived_ThenResponseStatusShouldBeOk()
        {
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Created"));
            Assert.That(_service.CallManager.StatusCode, Is.EqualTo(201));
        }

        [Test]
        public void GivenDeletePlaylistServiceRequestMade_WhenResponseReceived_ThenResponseStatusShouldBeO()
        {
            Assert.That(_service.JsonResponse["name"].ToString(), Is.EqualTo("MIB"));
        }

        [Test]
        public void PostCreatePlaylistServiceRequestMade_WhenResponseReceived_ThenResponseStatusShouldBeO()
        {
            Assert.That(_service.CreatePlaylistDTO.Response.type, Is.EqualTo("playlist"));
        }

        [Test]
        public void PostCreatePlaylistServiceRequestMade_WhenResponseReceived_ThenResponseStasShouldBeO()
        {
            Assert.That(_service.CreatePlaylistDTO.Response.description, Is.EqualTo("Test"));
        }
    }

    class PostCreatePlaylistTests_WithIncorrectId
    {
        PostCreatePlaylistService _service;

        [OneTimeSetUp]
        public async Task Setup()
        {
            _service = new PostCreatePlaylistService();
            await _service.MakeRequest("kmckm");
        }

        [Category("Sad Path")]
        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseRecieved_ThenResponseErrorShouldBe403()
        {
            Assert.That(_service.JsonResponse["error"]["status"].ToString(), Is.EqualTo("403"));
        }

        [Category("Sad Path")]
        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseRecieved_ThenResponseMessageShouldBeInvalidUsername()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("You cannot create a playlist for another user."));
        }
    }

    class PostCreatePlaylistTests_WithNoId
    {
        PostCreatePlaylistService _service;

        [OneTimeSetUp]
        public async Task Setup()
        {
            _service = new PostCreatePlaylistService();
            await _service.MakeRequest("");
        }

        [Category("Sad Path")]
        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseRecieved_ThenResponseNameShouldEqualToMIH()
        {
            Assert.That(_service.JsonResponse["error"]["status"].ToString(), Is.EqualTo("404"));
        }

        [Category("Sad Path")]
        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseRecieved_ThenResponseMessageShouldEqual()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("Invalid username"));
        }
    }
}
