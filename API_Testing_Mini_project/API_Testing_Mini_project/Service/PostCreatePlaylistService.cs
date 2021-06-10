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
        public DTO<PostCreatePlaylistModel> CreatePlaylistDTO { get; set; }
        public string Response { get; set; }

        public PostCreatePlaylistService()
        {
            CallManager = new CallManager();
            CreatePlaylistDTO = new DTO<PostCreatePlaylistModel>();
        }

        public async Task MakeRequest(string Id)
        {
            IdSelected = Id;

            Response = await CallManager.MakePostCreatePlaylistRequestAsync(Id);

            try
            {
                JsonResponse = JObject.Parse(Response);
            }
            catch 
            {
                JsonResponse = new JObject();
            }
            

            CreatePlaylistDTO.DeserealizeResponse(Response);
        }
    }
}
