using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace API_Testing_Mini_project
{
    public class WhenFollowArtistUserServiceIsCalled_WithAValidId
    {
        private PutFollowService _service;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _service = new PutFollowService();
            await _service.MakeRequest("artist", "2CIMQHirSU0MQqyYHq0eOx%2C57dN52uHvrHOxijzpIgu3E%2C1vCWHaC5f2uS3yhpwWbIA6");
        }

        [Category("Happy path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe200()
        {
            //Assert.That(_service.JsonResponse["status"].ToString(), Is.EqualTo("200"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("No Content"));
            //Assert.That(_service.GetArtistUserDTO.Response., Is.EqualTo(200));
        }
    }

    public class WhenFollowArtistUserServiceIsCalled_WithAnInvalidId
    {
        private PutFollowService _service;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _service = new PutFollowService();
            await _service.MakeRequest("artist", "InvalidId");
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
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("Invalid id: InvalidId"));
        }
    }

    public class WhenFollowArtistUserServiceIsCalled_WithNoId
    {
        private PutFollowService _service;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _service = new PutFollowService();
            await _service.MakeRequest("artist", "");
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
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("No ids given"));
        }
    }
}
