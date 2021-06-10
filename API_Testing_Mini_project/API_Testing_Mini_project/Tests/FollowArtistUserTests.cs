using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace API_Testing_Mini_project
{
    public class WhenFollowArtistUserServiceIsCalled_WithValidTypeAndAValidId
    {
        private PutFollowService _service;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _service = new PutFollowService();
            _service.MakeRequest("artist", "2CIMQHirSU0MQqyYHq0eOx%2C57dN52uHvrHOxijzpIgu3E%2C1vCWHaC5f2uS3yhpwWbIA6");
        }

        [Category("Happy path")]
        [Test]
        public void GivenFollowArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe204()
        {
            Assert.That(_service.CallManager.StatusCode, Is.EqualTo(204));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("No Content"));
        }
    }

    public class WhenFollowArtistUserServiceIsCalled_WithValidTypeAndAnInvalidId
    {
        private PutFollowService _service;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _service = new PutFollowService();
            _service.MakeRequest("artist", "InvalidId");
        }

        [Category("Sad path")]
        [Test]
        public void GivenFollowArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe400()
        {
            Assert.That(_service.JsonResponse["error"]["status"].ToString(), Is.EqualTo("400"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
        }

        [Category("Sad path")]
        [Test]
        public void GivenFollowArtistUserRequestMade_WhenResponseReceived_ThenAnErrorMessageShouldBeReceived()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("Invalid id: InvalidId"));
        }
    }

    public class WhenFollowArtistUserServiceIsCalled_WithValidTypeAndNoId
    {
        private PutFollowService _service;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _service = new PutFollowService();
            _service.MakeRequest("artist", "");
        }

        [Category("Sad path")]
        [Test]
        public void GivenFollowArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe400()
        {
            Assert.That(_service.JsonResponse["error"]["status"].ToString(), Is.EqualTo("400"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
        }

        [Category("Sad path")]
        [Test]
        public void GivenFollowArtistUserRequestMade_WhenResponseReceived_ThenAnErrorMessageShouldBeReceived()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("No ids given"));
        }
    }

    public class WhenFollowArtistUserServiceIsCalled_WithAnInvalidTypeAndAValidId
    {
        private PutFollowService _service;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _service = new PutFollowService();
            _service.MakeRequest("invalidtype", "2CIMQHirSU0MQqyYHq0eOx%2C57dN52uHvrHOxijzpIgu3E%2C1vCWHaC5f2uS3yhpwWbIA6");
        }

        [Category("Sad path")]
        [Test]
        public void GivenFollowArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe400()
        {
            Assert.That(_service.JsonResponse["error"]["status"].ToString(), Is.EqualTo("400"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
        }

        [Category("Sad path")]
        [Test]
        public void GivenFollowArtistUserRequestMade_WhenResponseReceived_ThenAnErrorMessageShouldBeReceived()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("Invalid type: invalidtype"));
        }
    }

    public class WhenFollowArtistUserServiceIsCalled_WithNoTypeAndAValidId
    {
        private PutFollowService _service;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _service = new PutFollowService();
            _service.MakeRequest("", "2CIMQHirSU0MQqyYHq0eOx%2C57dN52uHvrHOxijzpIgu3E%2C1vCWHaC5f2uS3yhpwWbIA6");
        }

        [Category("Sad path")]
        [Test]
        public void GivenFollowArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe400()
        {
            Assert.That(_service.JsonResponse["error"]["status"].ToString(), Is.EqualTo("400"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
        }

        [Category("Sad path")]
        [Test]
        public void GivenFollowArtistUserRequestMade_WhenResponseReceived_ThenAnErrorMessageShouldBeReceived()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("No type given"));
        }
    }

    public class WhenFollowArtistUserServiceIsCalled_OnAnArtistUserAlreadyFollowing
    {
        private PutFollowService _service;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _service = new PutFollowService();
            _service.MakeRequest("artist", "2CIMQHirSU0MQqyYHq0eOx%2C57dN52uHvrHOxijzpIgu3E%2C1vCWHaC5f2uS3yhpwWbIA6");
            _service.MakeRequest("artist", "2CIMQHirSU0MQqyYHq0eOx%2C57dN52uHvrHOxijzpIgu3E%2C1vCWHaC5f2uS3yhpwWbIA6");
        }

        [Category("Sad path")]
        [Test]
        public void GivenFollowArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe204()
        {
            Assert.That(_service.CallManager.StatusCode, Is.EqualTo(204));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("No Content"));
        }
    }
}