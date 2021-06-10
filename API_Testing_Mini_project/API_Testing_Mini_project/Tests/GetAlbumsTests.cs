using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace API_Testing_Mini_project
{
    public class WhenGetAlbumsServiceIsCalled_WithAValidSearchParameter
    {
        private GetAlbumsService _service;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _service = new GetAlbumsService();
            _service.MakeRequest("drake");
        }

        [Category("Happy path")]
        [Test]
        public void GivenGetAlbumsRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe200()
        {
            Assert.That(_service.CallManager.StatusCode, Is.EqualTo(200));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("OK"));
        }

        [Category("Happy path")]
        [Test]
        public void GivenGetAlbumsRequestMade_WhenResponseReceived_ThenResponseShouldContainDrake()
        {
            Assert.That(_service.GetAlbumsDTO.Response.artists.items.Where(x => x.name == "Drake").FirstOrDefault(), Is.Not.Null);
        }
    }

    public class WhenGetAlbumsServiceIsCalled_WithInappropriateSearchParameter
    {
        private GetAlbumsService _service;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _service = new GetAlbumsService();
            _service.MakeRequest("1454164317157");
        }

        [Category("Sad path")]
        [Test]
        public void GivenGetAlbumsRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe200()
        {
            //Assert.That(_service.CallManager.StatusCode, Is.EqualTo("200"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("OK"));
        }

        [Category("Sad path")]
        [Test]
        public void GivenGetAlbumsRequestMade_WhenResponseReceived_ThenResponseArtistItemsShouldBeEmpty()
        {
            Assert.That(_service.GetAlbumsDTO.Response.artists.items, Is.Empty);
        }
    }

    public class WhenGetAlbumsServiceIsCalled_WithNoSearchParameter
    {
        private GetAlbumsService _service;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _service = new GetAlbumsService();
            _service.MakeRequest("");
        }

        [Category("Sad path")]
        [Test]
        public void GivenGetAlbumsRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe400()
        {
            Assert.That(_service.JsonResponse["error"]["status"].ToString(), Is.EqualTo("400"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("Bad Request"));
        }

        [Category("Sad path")]
        [Test]
        public void GivenGetAlbumsRequestMade_WhenResponseReceived_ThenResponseShouldContainErrorMessage()
        {
            Assert.That(_service.JsonResponse["error"]["message"].ToString(), Is.EqualTo("No search query"));
        }
    }
}
