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
        public string ArtistSelected { get; set; }
        public DTO<GetAlbumsModel> GetAlbumsDTO { get; set; }
        public string Response { get; set; }

        public GetAlbumsService()
        {
            CallManager = new GetManager();
            GetAlbumsDTO = new DTO<GetAlbumsModel>();
        }

        public void MakeRequest(string searchParameter)
        {
            ArtistSelected = searchParameter;
            string resource = $"v1/search?q={searchParameter}&type=artist";

            Response = CallManager.MakeRequest(resource);

            JsonResponse = JObject.Parse(Response);

            GetAlbumsDTO.DeserealizeResponse(Response);
        }
    }
}
