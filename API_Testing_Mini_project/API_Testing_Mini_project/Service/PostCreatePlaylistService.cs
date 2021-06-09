using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Testing_Mini_project
{
    class PostCreatePlaylistService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }

        public string IdSelected { get; set; }
        //public DTO<GetFollowingArtistModel> FollowingArtistsDTO { get; set; }
        public string Response { get; set; }

        public PostCreatePlaylistService()
        {
            CallManager = new CallManager();
           // FollowingArtistsDTO = new DTO<GetFollowingArtistModel>();
        }

        public async Task MakeRequest(string Id)
        {
            Response = await CallManager.MakeGetFollowingArtistRequestAsync();

            JsonResponse = JObject.Parse(Response);

            //FollowingArtistsDTO.DeserealizeResponse(Response);
        }
    }
}
