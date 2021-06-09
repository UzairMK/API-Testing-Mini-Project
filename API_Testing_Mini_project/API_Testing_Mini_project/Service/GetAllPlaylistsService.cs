using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Testing_Mini_project.Service
{
    class GetAllPlaylistsService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }

        public string Response { get; set; }

        public GetAllPlaylistsService()
        {
            CallManager = new CallManager();
            //NameOfDTO = new DTO<>();
        }

        public async Task MakeRequest(string Id, string type)
        {

            Response = await CallManager.MakeGetAllPlaylistRequestAsync();

            JsonResponse = JObject.Parse(Response);

            //NameOfDTO.DeserealizeResponse(Response);
        }
    }
}
