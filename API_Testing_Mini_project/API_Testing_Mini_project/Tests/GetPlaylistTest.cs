using NUnit.Framework;
using System.Threading.Tasks;


namespace API_Testing_Mini_project
{
    class GetPlaylistTest
    {
        private GetPlaylistService _service;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _service = new GetPlaylistService();
            await _service.MakeRequest("7sf6IyQz843FD1Ndfmq3Wp");
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
        public async Task OneTimeSetUp()
        {
            _service = new GetPlaylistService();
            await _service.MakeRequest("invalidId");
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
        }

        [Category("Sad Path")]
        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseReceived_ThenResponseStatusShouldBeNull()
        {
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Not Found"));
        }
    }
}
