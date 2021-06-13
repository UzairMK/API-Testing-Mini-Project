using Newtonsoft.Json.Linq;

namespace API_Testing_Mini_project
{
    class PostCreatePlaylistService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public string IdSelected { get; set; }
        public DTO<PostCreatePlaylistModel> CreatePlaylistDTO { get; set; }
        public string Response { get; set; }

        public PostCreatePlaylistService()
        {
            CallManager = new PostManager();
            CreatePlaylistDTO = new DTO<PostCreatePlaylistModel>();
        }

        public void MakeRequest(string Id)
        {
            IdSelected = Id;
            string resource = $"v1/users/{Id}/playlists";

            Response = CallManager.MakeRequest(resource);

            JsonResponse = JObject.Parse(Response);

            CreatePlaylistDTO.DeserealizeResponse(Response);
        }
    }
}
