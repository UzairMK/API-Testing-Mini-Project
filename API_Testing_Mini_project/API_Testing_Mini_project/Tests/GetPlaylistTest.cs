using NUnit.Framework;
using System.Threading.Tasks;

<<<<<<< HEAD

namespace API_Testing_Mini_project
{
    class GetPlaylistTest
=======
namespace API_Testing_Mini_project
{
    class GetPlaylistTest_WithValidID
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
    {
        private GetPlaylistService _service;

        [OneTimeSetUp]
<<<<<<< HEAD
        public async Task OneTimeSetUp()
        {
            _service = new GetPlaylistService();
            await _service.MakeRequest("7sf6IyQz843FD1Ndfmq3Wp");
=======
        public void OneTimeSetUp()
        {
            _service = new GetPlaylistService();
            _service.MakeRequest("7sf6IyQz843FD1Ndfmq3Wp");
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
        }

        [Category("Happy Path")]
        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe200()
        {
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("OK"));
        }

        [Category("Happy Path")]
        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseRecieved_ThenResponseNameShouldEqualToMIH()
        {
            Assert.That(_service.GetPlaylistDTO.Response.name, Is.EqualTo("MIB"));
        }

        [Category("Happy Path")]
        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseRecieved_ThenResponseDescrShouldEqualToTest()
        {
            Assert.That(_service.GetPlaylistDTO.Response.description, Is.EqualTo("Test"));
        }
    }

    class GetPlaylistTest_WithInvalidId
    {
        private GetPlaylistService _service;

        [OneTimeSetUp]
<<<<<<< HEAD
        public async Task OneTimeSetUp()
        {
            _service = new GetPlaylistService();
            await _service.MakeRequest("invalidId");
=======
        public void OneTimeSetUp()
        {
            _service = new GetPlaylistService();
            _service.MakeRequest("invalidId");
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
        }

        [Category("Sad Path")]
        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe400()
        {
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Not Found"));
        }

        [Category("Sad Path")]
        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseRecieved_ThenResponseNameShouldEqualToMIH()
        {
            Assert.That(_service.JsonResponse["error"]["status"].ToString, Is.EqualTo("404"));
        }

        [Category("Sad Path")]
        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseRecieved_ThenResponseMessageShouldEqual()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString, Is.EqualTo("Invalid playlist Id"));
        }
    }

    class GetPlaylistTest_WithNoId
    {
        
        private GetPlaylistService _service;

        
        [OneTimeSetUp]
<<<<<<< HEAD
        public async Task OneTimeSetUp()
        {
            _service = new GetPlaylistService();
            await _service.MakeRequest(" ");
        }

        
        [Category("Sad Path")]
        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseReceived_ThenResponseNameShouldBeNull()
        {
            Assert.That(_service.GetPlaylistDTO.Response.name, Is.EqualTo(null));
=======
        public void OneTimeSetUp()
        {
            _service = new GetPlaylistService();
            _service.MakeRequest("");
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
        }

        [Category("Sad Path")]
        [Test]
<<<<<<< HEAD
        public void GivenGetPlaylistRequestMade_WhenResponseReceived_ThenResponseStatusShouldBeNull()
=======
        public void GivenGetPlaylistRequestMade_WhenResponseReceived_ThenResponseStatusShouldNotFound()
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
        {
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Not Found"));
        }
    }
}
