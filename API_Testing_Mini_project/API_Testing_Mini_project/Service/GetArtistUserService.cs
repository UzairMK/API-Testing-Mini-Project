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
        public DTO<GetArtistUserModel> GetArtistUserDTO { get; set; }
        public string Response { get; set; }

        public GetArtistUserService()
        {
            CallManager = new GetManager();
            GetArtistUserDTO = new DTO<GetArtistUserModel>();
        }

        public void MakeRequest(string Id)
        {
            IdSelected = Id;
            string resourse = $"v1/artists/{Id}";

            Response = CallManager.MakeRequest(resourse);

            JsonResponse = JObject.Parse(Response);

            GetArtistUserDTO.DeserealizeResponse(Response);
        }
    }
}
