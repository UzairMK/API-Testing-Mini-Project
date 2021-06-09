using Newtonsoft.Json.Linq;
using RestSharp;
using System.Threading.Tasks;

namespace API_Testing_Mini_project
{
    public class CallManager : ICallManager
    {
        private readonly IRestClient _client;

        public string StatusDescription { get; set; }

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
        }

        public async Task<string> ExecuteRequestAsync(RestRequest request)
        {
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", AppConfigReader.AuthKey);

            var response = await _client.ExecuteAsync(request);

            StatusDescription = response.StatusDescription.ToString();

            return response.Content;
        }

        public async Task<string> MakeGetArtistUserRequestAsync(string Id)
        {
            var request = new RestRequest(Method.GET)
            {
                Resource = $"v1/artists/{Id}"
            };

            return await ExecuteRequestAsync(request);
        }

        public async Task<string> MakeGetAlbumRequestAsync(string name, string type)
        {

            var request = new RestRequest(Method.GET)
            {
                Resource = $"v1/search?q={name}&type={type}"
            };

            return await ExecuteRequestAsync(request);
        }

        public async Task<string> MakeGetFollowingArtistRequestAsync(string artist)
        {

            var request = new RestRequest(Method.GET)
            {
                Resource = $"v1/me/following?type={artist}"
            };

            return await ExecuteRequestAsync(request);
        }

        public async Task<string> MakePutFollowRequestAsync(string type, string iD)
        {

            var request = new RestRequest(Method.PUT)
            {
                Resource = $"v1/me/following?type={type}&ids={iD}"
            };

            return await ExecuteRequestAsync(request);
        }
        public async Task<string> MakeDeleteFollowRequestAsync(string type, string iD)
        {

            var request = new RestRequest(Method.DELETE)
            {
                Resource = $"v1/me/following?type={type}&ids={iD}"
            };

            return await ExecuteRequestAsync(request);
        }


    }
}
