using RestSharp;
using System.Threading.Tasks;

namespace API_Testing_Mini_project
{
    public interface ICallManager
    {
        string StatusDescription { get; set; }
        Task<string> MakeGetArtistUserRequestAsync(string Id);
        Task<string> ExecuteRequestAsync(RestRequest request);
    }
}
