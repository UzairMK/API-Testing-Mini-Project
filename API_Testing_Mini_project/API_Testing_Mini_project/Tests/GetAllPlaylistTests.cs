<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
=======
﻿using NUnit.Framework;
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399

namespace API_Testing_Mini_project
{
    class GetAllPlaylistTests
    {
        private GetAllPlaylistsService _service;

        [OneTimeSetUp]
<<<<<<< HEAD
        public async Task OneTimeSetUp()
        {
            _service = new GetAllPlaylistsService();
            await _service.MakeRequest();
=======
        public void OneTimeSetUp()
        {
            _service = new GetAllPlaylistsService();
            _service.MakeRequest();
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
        }

        [Category("Happy Path")]
        [Test]
        public void GivenGetAllPlaylistRequestMade_WhenResponseReceived_ThenResponseStatusShouldBe200()
        {
            Assert.That(_service.CallManager.StatusDescription, Is.EqualTo("OK"));
            Assert.That(_service.CallManager.StatusCode, Is.EqualTo(200));
        }

<<<<<<< HEAD
        [Category("Happy Path")]
        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseRecieved_ThenResponseNameShouldEqualToRicos_Room()
        {

            var temp = _service.GetAllPlaylistDTO.Response.items.Where(x => x.name == "Rico's Room").ToList();
            
            Assert.That(temp[0].name, Is.EqualTo("Rico's Room"));
        }

        [Category("Happy Path")]
        [Test]
        public void GivenGetPlaylistRequestMade_WhenResponseRecieved_ThenResponseIdShouldEqualToId()
        {

            var temp = _service.GetAllPlaylistDTO.Response.items.Where(x => x.name == "Rico's Room").ToList();

            Assert.That(temp[0].id, Is.EqualTo("0hZjiDkbrvLpgbpVU7F0EM"));
            Assert.That(temp[0].type, Is.EqualTo("playlist"));
        }
=======
        //[Category("Happy Path")]
        //[Test]
        //public void GivenGetPlaylistRequestMade_WhenResponseRecieved_ThenResponseNameShouldEqualToRicos_Room()
        //{

        //    var temp = _service.GetAllPlaylistDTO.Response.items.Where(x => x.name == "Rico's Room").ToList();
            
        //    Assert.That(temp[0].name, Is.EqualTo("Rico's Room"));
        //}

        //[Category("Happy Path")]
        //[Test]
        //public void GivenGetPlaylistRequestMade_WhenResponseRecieved_ThenResponseIdShouldEqualToId()
        //{

        //    var temp = _service.GetAllPlaylistDTO.Response.items.Where(x => x.name == "Rico's Room").ToList();

        //    Assert.That(temp[0].id, Is.EqualTo("0hZjiDkbrvLpgbpVU7F0EM"));
        //    Assert.That(temp[0].type, Is.EqualTo("playlist"));
        //}
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
    }
}
