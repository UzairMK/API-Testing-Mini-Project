using RestSharp;
using System.Threading.Tasks;

namespace API_Testing_Mini_project
{
    public interface ICallManager2
    {
        int StatusCode { get; set; }
        string StatusDescription { get; set; }
        string MakeRequest(string resource);
    }
}
