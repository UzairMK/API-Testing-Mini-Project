using Newtonsoft.Json.Linq;

namespace API_Testing_Mini_project
{
    class GetAllPlaylistsService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }

        public DTO<AllPlaylistModel> GetAllPlaylistDTO { get; set; }
        public string Response { get; set; }

        public GetAllPlaylistsService()
        {
            CallManager = new GetManager();
            GetAllPlaylistDTO = new DTO<AllPlaylistModel>();
        }

        public void MakeRequest()
        {
            string resource = $"v1/me/playlists";

            Response = CallManager.MakeRequest(resource);


            try
            {
                JsonResponse = JObject.Parse(Response);
            }
            catch
            {
                JsonResponse = new JObject();
            }
            

            GetAllPlaylistDTO.DeserealizeResponse(Response);
        }
    }
}
