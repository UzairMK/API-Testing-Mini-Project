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
    class GetAllPlaylistsService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
<<<<<<< HEAD
=======

>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
        public DTO<AllPlaylistModel> GetAllPlaylistDTO { get; set; }
        public string Response { get; set; }

        public GetAllPlaylistsService()
        {
<<<<<<< HEAD
            CallManager = new CallManager();
            GetAllPlaylistDTO = new DTO<AllPlaylistModel>();
        }

        public async Task MakeRequest()
        {

            Response = await CallManager.MakeGetAllPlaylistRequestAsync();
=======
            CallManager = new GetManager();
            GetAllPlaylistDTO = new DTO<AllPlaylistModel>();
        }

        public void MakeRequest()
        {
            string resource = $"v1/me/playlists";

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
            

            GetAllPlaylistDTO.DeserealizeResponse(Response);
        }
    }
}
