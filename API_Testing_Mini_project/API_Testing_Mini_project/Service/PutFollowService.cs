using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Testing_Mini_project
{
    class PutFollowService
    {
<<<<<<< HEAD
            public ICallManager CallManager { get; set; }
            public JObject JsonResponse { get; set; }

            public string Type { get; set; }
            public string Id { get; set; }

            public string Response { get; set; }
=======
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public string Response { get; set; }

        public PutFollowService()
        {
            CallManager = new PutManager();
        }

        public void MakeRequest(string type, string iD)
        {
            Type = type;
            Id = iD;
            string resource = $"v1/me/following?type={type}&ids={iD}";

            Response = CallManager.MakeRequest(resource);
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399

            try
            {
<<<<<<< HEAD
                CallManager = new CallManager();
            }

            public async Task MakeRequest(string iD, string type)
            {
                Id = iD;
                Type = type;

                Response = await CallManager.MakePutFollowRequestAsync(type,iD);

                JsonResponse = JObject.Parse(Response);
=======
                JsonResponse = JObject.Parse(Response);
            }
            catch
            {
                JsonResponse = new JObject();
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
            }
        }
    }
}
