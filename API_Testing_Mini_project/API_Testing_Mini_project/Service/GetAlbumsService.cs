using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Testing_Mini_project
{
    class GetAlbumsService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public string IdSelected { get; set; }
        public string typeSelected { get; set; }
        //public DTO<> NameOfDTO { get; set; }
        public string Response { get; set; }

        public GetAlbumsService()
        {
            CallManager = new CallManager();
            //NameOfDTO = new DTO<>();
        }

        public async Task MakeRequest(string Id, string type)
        {
            IdSelected = Id;
            typeSelected = type;

            Response = await CallManager.MakeGetAlbumRequestAsync(Id, type);

            JsonResponse = JObject.Parse(Response);

            //NameOfDTO.DeserealizeResponse(Response);
        }
    }
}
