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
    class DeletePlaylistService
    {
<<<<<<< HEAD
            public ICallManager CallManager { get; set; }
            public JObject JsonResponse { get; set; }
            public string IdSelected { get; set; }
            public string Response { get; set; }

            public DeletePlaylistService()
            {
                CallManager = new CallManager();
            }

            public async Task MakeRequest(string Id)
            {
                IdSelected = Id;

                Response = await CallManager.MakeDeletePlaylistRequestAsync(Id);
=======
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public string IdSelected { get; set; }
        public string Response { get; set; }

        public DeletePlaylistService()
        {
            CallManager = new DeleteManager();
        }

        public void MakeRequest(string Id)
        {
            IdSelected = Id;
            string resource = $"v1/playlists/{Id}/followers";

            Response = CallManager.MakeRequest(resource);
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399

            try
            {
                JsonResponse = JObject.Parse(Response);
            }
<<<<<<< HEAD
            catch 
            {
                JsonResponse = new JObject();
            }
   
            }
        }
    }
=======
            catch
            {
                JsonResponse = new JObject();
            }

        }
    }
}
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
