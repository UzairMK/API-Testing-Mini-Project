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
    class PostCreatePlaylistService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
<<<<<<< HEAD

=======
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
        public string IdSelected { get; set; }
        public DTO<PostCreatePlaylistModel> CreatePlaylistDTO { get; set; }
        public string Response { get; set; }

        public PostCreatePlaylistService()
        {
<<<<<<< HEAD
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
            
=======
            CallManager = new PostManager();
            CreatePlaylistDTO = new DTO<PostCreatePlaylistModel>();
        }

        public void MakeRequest(string Id)
        {
            IdSelected = Id;
            string resource = $"v1/users/{Id}/playlists";

            Response = CallManager.MakeRequest(resource);

            JsonResponse = JObject.Parse(Response);
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399

            CreatePlaylistDTO.DeserealizeResponse(Response);
        }
    }
}
