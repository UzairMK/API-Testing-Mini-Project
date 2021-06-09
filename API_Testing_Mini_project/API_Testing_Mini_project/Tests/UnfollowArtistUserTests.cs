using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace API_Testing_Mini_project
{
    public class WhenUnfollowArtistUserServiceIsCalled_WithAValidId
    {
        private DeleteFollowService _service;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _service = new DeleteFollowService();
            await _service.MakeRequest("artist", "");
        }

        [Category("Happy path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe200()
        {
            //Assert.That(_service.JsonResponse["status"].ToString(), Is.EqualTo("200"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("OK"));
            //Assert.That(_service.GetArtistUserDTO.Response., Is.EqualTo(200));
        }

        [Category("Happy path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenResponseNameShouldBeKanyeWest()
        {
            Assert.That(_service.JsonResponse["name"].ToString(), Is.EqualTo("Kanye West"));
        }
    }

    public class WhenUnfollowArtistUserServiceIsCalled_WithAnInvalidId
    {
        private DeleteFollowService _service;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _service = new DeleteFollowService();
            await _service.MakeRequest("artist", "InvalidId");
        }

        [Category("Sad path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe400()
        {
            //Assert.That(_service.JsonResponse["status"].ToString(), Is.EqualTo("200"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
        }

        [Category("Sad path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenAnErrorMessageShouldBeReceived()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("Kanye West"));
        }
    }

    public class WhenUnfollowArtistUserServiceIsCalled_WithNoId
    {
        private DeleteFollowService _service;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _service = new DeleteFollowService();
            await _service.MakeRequest("artist", "");
        }

        [Category("Sad path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe200()
        {
            //Assert.That(_service.JsonResponse["status"].ToString(), Is.EqualTo("200"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
        }

        [Category("Sad path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenAnErrorMessageShouldBeReceived()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("Kanye West"));
        }
    }
}
