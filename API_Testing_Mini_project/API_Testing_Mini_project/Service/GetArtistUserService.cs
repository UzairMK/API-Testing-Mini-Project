using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Testing_Mini_project
{
    public class GetArtistUserService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public string IdSelected { get; set; }
        //public DTO<> NameOfDTO { get; set; }
        public string Response { get; set; }

        public GetArtistUserService()
        {
            CallManager = new CallManager();
            //NameOfDTO = new DTO<>();
        }

        public async Task MakeRequest(string Id)
        {
            IdSelected = Id;

            Response = await CallManager.MakeGetArtistUserRequestAsync(Id);

            JsonResponse = JObject.Parse(Response);

            //NameOfDTO.DeserealizeResponse(Response);
        }
    }
}
