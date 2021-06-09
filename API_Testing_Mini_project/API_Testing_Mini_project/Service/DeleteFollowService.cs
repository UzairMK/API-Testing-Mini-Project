using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Testing_Mini_project
{
    class DeleteFollowService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }

        public string Type { get; set; }
        public string Id { get; set; }
        //public string IdSelected { get; set; }
        //public DTO<> NameOfDTO { get; set; }
        public string Response { get; set; }

        public DeleteFollowService()
        {
            CallManager = new CallManager();
            //NameOfDTO = new DTO<>();
        }

        public async Task MakeRequest(string type, string iD)
        {
            Type = type;
            Id = iD;

            Response = await CallManager.MakePutFollowRequestAsync(type, iD);

            JsonResponse = JObject.Parse(Response);

            //NameOfDTO.DeserealizeResponse(Response);
        }
    }
}
