using Newtonsoft.Json.Linq;
using RestSharp;
using System.Threading.Tasks;

namespace API_Testing_Mini_project
{
    public static class ExecuteRequest
    {
        public static string Execute(RestRequest request, out int statusCode, out string statusDescription)
        {
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", AppConfigReader.AuthKey);

            var response = new RestClient(AppConfigReader.BaseUrl).Execute(request);

            statusCode = (int)response.StatusCode;
            statusDescription = response.StatusDescription;

            return response.Content;
        }
    }
}
