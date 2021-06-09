using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace API_Testing_Mini_project
{
    public class WhenUnfollowArtistUserServiceIsCalled_WithAValidId
    {
        private GetArtistUserService _service;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _service = new GetArtistUserService();
            await _service.MakeRequest("5K4W6rqBFWDnAN6FQUkS6x");
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
        private GetArtistUserService _service;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _service = new GetArtistUserService();
            await _service.MakeRequest("InvalidId");
        }

        [Category("Sad path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe400()
        {
            //Assert.That(_service.JsonResponse["status"].ToString(), Is.EqualTo("200"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
            //Assert.That(_service.GetArtistUserDTO.Response., Is.EqualTo(200));
        }

        [Category("Sad path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenAnErrorMessageShouldBeReceived()
        {
            Assert.That(_service.JsonResponse["name"].ToString(), Is.EqualTo("Kanye West"));
        }
    }

    public class WhenUnfollowArtistUserServiceIsCalled_WithNoId
    {
        private GetArtistUserService _service;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _service = new GetArtistUserService();
            await _service.MakeRequest("");
        }

        [Category("Sad path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe200()
        {
            //Assert.That(_service.JsonResponse["status"].ToString(), Is.EqualTo("200"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
            //Assert.That(_service.GetArtistUserDTO.Response., Is.EqualTo(200));
        }

        [Category("Sad path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenAnErrorMessageShouldBeReceived()
        {
            Assert.That(_service.JsonResponse["name"].ToString(), Is.EqualTo("Kanye West"));
        }
    }
}
