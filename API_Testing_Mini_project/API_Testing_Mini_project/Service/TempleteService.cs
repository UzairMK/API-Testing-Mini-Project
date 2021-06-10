using Newtonsoft.Json.Linq;

namespace API_Testing_Mini_project
{
    class TemplateService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public string Response { get; set; }

        public TemplateService()
        {
            //CallManager = new CallManager();
        }

        public void MakeRequest()
        {
            string resource = $"";

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
