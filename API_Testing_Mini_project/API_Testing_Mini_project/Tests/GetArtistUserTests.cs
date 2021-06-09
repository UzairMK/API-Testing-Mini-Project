using System;
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
            await _service.MakeRequest("");
        }

        [Category("Happy path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe200()
        {
            Assert.That(_service.JsonResponse["status"].ToString(), Is.EqualTo("200"));
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("OK"));
            //Assert.That(_service.NameOfDTO.Response.status, Is.EqualTo(200));
        }

        [Category("Happy path")]
        [Test]
        public void GivenGetArtistUserRequestMade_WhenResponseReceived_ThenResponseNameShouldBe()
        {
            Assert.That(_service.JsonResponse["status"].ToString(), Is.EqualTo("200"));
        }
    }
}
