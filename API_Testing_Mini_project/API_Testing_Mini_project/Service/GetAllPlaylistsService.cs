using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Testing_Mini_project
{
    class GetAllPlaylistsService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public DTO<AllPlaylistModel> GetAllPlaylistDTO { get; set; }
        public string Response { get; set; }

        public GetAllPlaylistsService()
        {
            CallManager = new CallManager();
            GetAllPlaylistDTO = new DTO<AllPlaylistModel>();
        }

        public async Task MakeRequest()
        {

            Response = await CallManager.MakeGetAllPlaylistRequestAsync();


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
