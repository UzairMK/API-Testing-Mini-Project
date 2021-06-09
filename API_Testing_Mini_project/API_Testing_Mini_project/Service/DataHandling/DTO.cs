using Newtonsoft.Json;

namespace API_Testing_Mini_project
{
    public class DTO<ResponseType> where ResponseType : IResponse, new()
    {
        public ResponseType Response { get; set; }

        public void DeserealizeResponse(string jsonResponse)
        {
            Response = JsonConvert.DeserializeObject<ResponseType>(jsonResponse);
        }
    }
}