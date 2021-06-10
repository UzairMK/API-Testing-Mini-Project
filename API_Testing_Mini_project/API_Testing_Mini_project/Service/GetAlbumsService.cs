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
            CallManager = new CallManager();
            GetAlbumsDTO = new DTO<GetAlbumsModel>();
        }

        public async Task MakeRequest(string searchParameter)
        {
            ArtistSelected = searchParameter;

            Response = await CallManager.MakeGetAlbumRequestAsync(searchParameter);

            JsonResponse = JObject.Parse(Response);

            GetAlbumsDTO.DeserealizeResponse(Response);
        }
    }
}
