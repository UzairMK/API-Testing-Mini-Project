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
<<<<<<< HEAD
        public string IdSelected { get; set; }
        //public DTO<> NameOfDTO { get; set; }
=======
        public string Id { get; set; }
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399
        public string Response { get; set; }

        public DeleteFollowService()
        {
            CallManager = new DeleteManager();
        }

        public void MakeRequest(string type, string iD)
        {
            Type = type;
<<<<<<< HEAD
            IdSelected = iD;
=======
            Id = iD;
            string resource = $"v1/me/following?type={type}&ids={iD}";
>>>>>>> 976dd6ac9f70778bcf8b3de6d82e006e85428399

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
