using Newtonsoft.Json.Linq;

namespace API_Testing_Mini_project
{
    class DeletePlaylistService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public string IdSelected { get; set; }
        public string Response { get; set; }

        public DeletePlaylistService()
        {
            CallManager = new DeleteManager();
        }

        public void MakeRequest(string Id)
        {
            IdSelected = Id;
            string resource = $"v1/playlists/{Id}/followers";

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
