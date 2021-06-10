using Newtonsoft.Json.Linq;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399

namespace API_Testing_Mini_project
{
    class GetPlaylistService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public string IdSelected { get; set; }
<<<<<<< HEAD
        public DTO<Playlist> GetPlaylistDTO { get; set; }
=======
        public DTO<PlaylistModel> GetPlaylistDTO { get; set; }
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
        public string Response { get; set; }

        public GetPlaylistService()
        {
<<<<<<< HEAD
            CallManager = new CallManager();
            GetPlaylistDTO = new DTO<Playlist>();
        }

        public async Task MakeRequest(string Id)
        {
            IdSelected = Id;

            Response = await CallManager.MakeGetSinglePlaylistRequestAsync(Id);

=======
            CallManager = new GetManager();
            GetPlaylistDTO = new DTO<PlaylistModel>();
        }

        public void MakeRequest(string Id)
        {
            IdSelected = Id;
            string resource = $"v1/playlists/{Id}";

            Response = CallManager.MakeRequest(resource);
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
            try
            {
                JsonResponse = JObject.Parse(Response);
            }
            catch 
            {
                JsonResponse = new JObject();
            }
<<<<<<< HEAD
            
=======
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399

            GetPlaylistDTO.DeserealizeResponse(Response);
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
