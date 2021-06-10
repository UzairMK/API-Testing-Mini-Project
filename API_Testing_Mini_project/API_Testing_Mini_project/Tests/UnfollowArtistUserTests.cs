using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace API_Testing_Mini_project
{
    public class WhenUnfollowArtistUserServiceIsCalled_WithAValidTypeAndAValidId
    {
        private DeleteFollowService _service;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _service = new DeleteFollowService();
            await _service.MakeRequest("artist", "2CIMQHirSU0MQqyYHq0eOx%2C57dN52uHvrHOxijzpIgu3E%2C1vCWHaC5f2uS3yhpwWbIA6");
        }

        [Category("Happy path")]
        [Test]
        public void GivenUnfollowArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe204()
        {
            //Assert.That(_service.CallManager.StatusCode, Is.EqualTo("204"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("No Content"));
        }
    }

    public class WhenUnfollowArtistUserServiceIsCalled_WithAValidTypeAndAnInvalidId
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
        public void GivenUnfollowArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe400()
        {
            //Assert.That(_service.CallManager.StatusCode, Is.EqualTo("400"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
        }

        [Category("Sad path")]
        [Test]
        public void GivenUnfollowArtistUserRequestMade_WhenResponseReceived_ThenAnErrorMessageShouldBeReceived()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("Invalid id: InvalidId"));
        }
    }

    public class WhenUnfollowArtistUserServiceIsCalled_WithAValidTypeAndNoId
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
        public void GivenUnfollowArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe400()
        {
            //Assert.That(_service.CallManager.StatusCode, Is.EqualTo("400"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
        }

        [Category("Sad path")]
        [Test]
        public void GivenUnfollowArtistUserRequestMade_WhenResponseReceived_ThenAnErrorMessageShouldBeReceived()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("No ids given"));
        }
    }

    public class WhenUnfollowArtistUserServiceIsCalled_WithAnInvalidTypeAndAValidId
    {
        private DeleteFollowService _service;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _service = new DeleteFollowService();
            await _service.MakeRequest("invalidtype", "2CIMQHirSU0MQqyYHq0eOx%2C57dN52uHvrHOxijzpIgu3E%2C1vCWHaC5f2uS3yhpwWbIA6");
        }

        [Category("Sad path")]
        [Test]
        public void GivenUnfollowArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe400()
        {
            //Assert.That(_service.CallManager.StatusCode, Is.EqualTo("400"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
        }

        [Category("Sad path")]
        [Test]
        public void GivenUnfollowArtistUserRequestMade_WhenResponseReceived_ThenAnErrorMessageShouldBeReceived()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("Invalid type: invalidtype"));
        }
    }

    public class WhenUnfollowArtistUserServiceIsCalled_WithNoTypeAndAValidId
    {
        private DeleteFollowService _service;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _service = new DeleteFollowService();
            await _service.MakeRequest("", "2CIMQHirSU0MQqyYHq0eOx%2C57dN52uHvrHOxijzpIgu3E%2C1vCWHaC5f2uS3yhpwWbIA6");
        }

        [Category("Sad path")]
        [Test]
        public void GivenUnfollowArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe400()
        {
            //Assert.That(_service.CallManager.StatusCode, Is.EqualTo("400"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
        }

        [Category("Sad path")]
        [Test]
        public void GivenUnfollowArtistUserRequestMade_WhenResponseReceived_ThenAnErrorMessageShouldBeReceived()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("No type given"));
        }
    }

    public class WhenUnfollowArtistUserServiceIsCalled_OnArtistUserYouAreNotFollowing
    {
        private DeleteFollowService _service;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _service = new DeleteFollowService();
            await _service.MakeRequest("artist", "2CIMQHirSU0MQqyYHq0eOx%2C57dN52uHvrHOxijzpIgu3E%2C1vCWHaC5f2uS3yhpwWbIA6");
            await _service.MakeRequest("artist", "2CIMQHirSU0MQqyYHq0eOx%2C57dN52uHvrHOxijzpIgu3E%2C1vCWHaC5f2uS3yhpwWbIA6");
        }

        [Category("Sad path")]
        [Test]
        public void GivenUnfollowArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe204()
        {
            //Assert.That(_service.CallManager.StatusCode, Is.EqualTo("204"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("No Content"));
        }
    }
}
