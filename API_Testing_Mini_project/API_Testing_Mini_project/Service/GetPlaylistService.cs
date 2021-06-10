﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Testing_Mini_project
{
    class GetPlaylistService
    {
        public ICallManager CallManager { get; set; }
        public JObject JsonResponse { get; set; }
        public string IdSelected { get; set; }
        public DTO<Playlist> GetPlaylistDTO { get; set; }
        public string Response { get; set; }

        public GetPlaylistService()
        {
            CallManager = new CallManager();
            GetPlaylistDTO = new DTO<Playlist>();
        }

        public async Task MakeRequest(string Id)
        {
            IdSelected = Id;

            Response = await CallManager.MakeGetSinglePlaylistRequestAsync(Id);

            try
            {
                JsonResponse = JObject.Parse(Response);
            }
            catch 
            {
                JsonResponse = new JObject();
            }
            

            GetPlaylistDTO.DeserealizeResponse(Response);
        }
    }
}
