using RestSharp;
using System.Threading.Tasks;

namespace API_Testing_Mini_project
{
    public interface ICallManager
    {
        string StatusCode { get; set; }
        string StatusDescription { get; set; }
        Task<string> MakeGetArtistUserRequestAsync(string Id);
        Task<string> MakeGetFollowingArtistRequestAsync();
        Task<string> MakeGetAlbumRequestAsync(string searchParameter);
        Task<string> MakePutFollowRequestAsync(string type, string iD);
        Task<string> MakeDeleteFollowRequestAsync(string type, string iD);
        Task<string> ExecuteRequestAsync(RestRequest request);
    }
}
