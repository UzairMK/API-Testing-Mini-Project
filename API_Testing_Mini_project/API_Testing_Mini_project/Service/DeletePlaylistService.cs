using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Testing_Mini_project.Service
{
    class DeletePlaylistService
    {
            public ICallManager CallManager { get; set; }
            public JObject JsonResponse { get; set; }
            public string IdSelected { get; set; }
            public string Response { get; set; }

            public DeletePlaylistService()
            {
                CallManager = new CallManager();
            }

            public async Task MakeRequest(string Id)
            {
                IdSelected = Id;

                Response = await CallManager.MakeGetArtistUserRequestAsync(Id);

                JsonResponse = JObject.Parse(Response);
            }
        }
    }
