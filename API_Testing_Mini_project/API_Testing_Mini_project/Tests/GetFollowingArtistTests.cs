using System.Threading.Tasks;
using NUnit.Framework;

namespace API_Testing_Mini_project
{
    public class WhenGetFollowingArtistServiceIsCalled_WithAValidId
    {
        private GetFollowingArtistService _service;

        [OneTimeSetUp]
        public async Task OneTimeSetUp()
        {
            _service = new GetFollowingArtistService();
            await _service.MakeRequest();
        }

        [Category("Happy path")]
        [Test]
        public void GivenGetFollowingArtistRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe200()
        {
            //Assert.That(_service.CallManager.StatusCode, Is.EqualTo("200"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("OK"));
        }

        [Category("Happy path")]
        [Test]
        public void GivenGetFollowingArtistRequestMade_WhenResponseReceived_ThenResponseShouldContainBPOLYMATH()
        {
            Assert.That(_service.FollowingArtistsDTO.Response.artists.items[0].name, Is.EqualTo("B POLYMATH"));
        }
    }
}
