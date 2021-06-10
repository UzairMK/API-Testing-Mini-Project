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
        //public DTO<> NameOfDTO { get; set; }
        public string Response { get; set; }

        public GetAlbumsService()
        {
            CallManager = new CallManager();
            //NameOfDTO = new DTO<>();
        }

        public async Task MakeRequest(string artistName)
        {
            ArtistSelected = artistName;

            Response = await CallManager.MakeGetAlbumRequestAsync(artistName);

            JsonResponse = JObject.Parse(Response);

            //NameOfDTO.DeserealizeResponse(Response);
        }
    }
}
