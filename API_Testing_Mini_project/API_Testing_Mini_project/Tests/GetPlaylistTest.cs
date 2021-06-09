using NUnit.Framework;
using System.Threading.Tasks;


namespace API_Testing_Mini_project
{
    class GetPlaylistTest
    {
        private GetPlaylistService _service;
        string playlistId = "7sf6IyQz843FD1Ndfmq3Wp";

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
            Assert.That(_service.CallManager, Is.EqualTo("OK"));
        }

        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseRecieved_ThenResponseNameShouldEqualToMIH()
        {
            Assert.That(_service.GetPlaylistDTO.Response.name, Is.EqualTo("MIH"));
        }

        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseRecieved_ThenResponseDescrShouldEqualToTest()
        {
            Assert.That(_service.GetPlaylistDTO.Response.description, Is.EqualTo("Test"));
        }


        //when i enter the correct id i get status = 200
        // when i run parameter = correct parameter
        // when i enter an incorrect id i get blah blah

    }
}
