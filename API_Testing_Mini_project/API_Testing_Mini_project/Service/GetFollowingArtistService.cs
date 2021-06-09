using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Testing_Mini_project
{
    class GetFollowingArtistService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }

        public string Artist { get; set; }
        //public string IdSelected { get; set; }
        //public DTO<> NameOfDTO { get; set; }
        public string Response { get; set; }

        public GetFollowingArtistService()
        {
            CallManager = new CallManager();
            //NameOfDTO = new DTO<>();
        }

        public async Task MakeRequest(string artist)
        {
            Artist = artist;

            Response = await CallManager.MakeGetFollowingArtistRequestAsync(artist);

            JsonResponse = JObject.Parse(Response);

            //NameOfDTO.DeserealizeResponse(Response);
        }
    }
}
