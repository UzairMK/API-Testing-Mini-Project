﻿using RestSharp;
using System.Threading.Tasks;

namespace API_Testing_Mini_project
{
    public interface ICallManager
    {
        string StatusDescription { get; set; }
        Task<string> MakeGetArtistUserRequestAsync(string Id);
        Task<string> MakeGetFollowingArtistRequestAsync(string artist);
        Task<string> MakeGetAlbumRequestAsync(string name, string type);
        Task<string> MakePutFollowRequestAsync(string type, string iD);
        Task<string> MakeDeleteFollowRequestAsync(string type, string iD);
        Task<string> ExecuteRequestAsync(RestRequest request);
    }
}
