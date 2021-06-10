using System.Threading.Tasks;
using NUnit.Framework;

namespace API_Testing_Mini_project
{
    public class WhenGetArtistUserServiceIsCalled_WithAValidId
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
            //Assert.That(_service.CallManager.StatusCode, Is.EqualTo("200"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("OK"));
        }

        [Category("Happy path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenResponseNameShouldBeKanyeWest()
        {
            Assert.That(_service.JsonResponse["name"].ToString(), Is.EqualTo("Kanye West"));
        }
    }

    public class WhenGetArtistUserServiceIsCalled_WithAnInvalidId
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
            Assert.That(_service.JsonResponse["error"]["status"].ToString(), Is.EqualTo("400"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
        }

        [Category("Sad path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenAnErrorMessageShouldBeReceived()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("invalid id"));
        }
    }

    public class WhenGetArtistUserServiceIsCalled_WithNoId
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
            Assert.That(_service.JsonResponse["error"]["status"].ToString(), Is.EqualTo("400"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
        }

        [Category("Sad path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenAnErrorMessageShouldBeReceived()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("invalid id"));
        }
    }
}
