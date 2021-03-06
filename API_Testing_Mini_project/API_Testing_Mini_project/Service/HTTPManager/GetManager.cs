using RestSharp;

namespace API_Testing_Mini_project
{
    public class GetManager : ICallManager
    {
        public int StatusCode { get; set; }
        public string StatusDescription { get; set; }

        public string MakeRequest(string resource)
        {
            var request = new RestRequest(Method.GET)
            {
                Resource = resource
            };

            string response = ExecuteRequest.Execute(request, out int statusCode, out string statusDescription);
            StatusCode = statusCode;
            StatusDescription = statusDescription;

            return response;
        }
    }
}
