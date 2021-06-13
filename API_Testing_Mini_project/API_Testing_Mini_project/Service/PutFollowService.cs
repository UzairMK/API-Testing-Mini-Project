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

            try
            {
                JsonResponse = JObject.Parse(Response);
            }
            catch
            {
                JsonResponse = new JObject();
            }
        }
    }
}
