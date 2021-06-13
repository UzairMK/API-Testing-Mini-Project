using Newtonsoft.Json.Linq;

namespace API_Testing_Mini_project
{
    class GetFollowingArtistService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public DTO<GetFollowingArtistModel> FollowingArtistsDTO { get; set; }
        public string Response { get; set; }

        public GetFollowingArtistService()
        {
            CallManager = new GetManager();
            FollowingArtistsDTO = new DTO<GetFollowingArtistModel>();
        }

        public void MakeRequest()
        {
            string resource = $"v1/me/following?type=artist";

            Response = CallManager.MakeRequest(resource);

            JsonResponse = JObject.Parse(Response);

            FollowingArtistsDTO.DeserealizeResponse(Response);
        }
    }
}
