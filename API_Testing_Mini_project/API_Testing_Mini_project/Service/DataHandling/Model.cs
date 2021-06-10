using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Testing_Mini_project
{
    public class GetArtistUserModel : IResponse
    {
        public External_Urls external_urls { get; set; }
        public Followers followers { get; set; }
        public string[] genres { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public Image[] images { get; set; }
        public string name { get; set; }
        public int popularity { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class External_Urls
    {
        public string spotify { get; set; }
    }

    public class Followers
    {
        public object href { get; set; }
        public int total { get; set; }
    }

    public class Image
    {
        public int height { get; set; }
        public string url { get; set; }
        public int width { get; set; }
    }

    public class GetAblumsModel : IResponse
    {

    }


    public class GetFollowingArtistModel : IResponse
    {
        public Artists artists { get; set; }
    }

    public class Artists
    {
        public Item[] items { get; set; }
        public object next { get; set; }
        public int total { get; set; }
        public Cursors cursors { get; set; }
        public int limit { get; set; }
        public string href { get; set; }
    }

    public class Cursors
    {
        public object after { get; set; }
    }

    public class Item
    {
        public External_Urls external_urls { get; set; }
        public Followers followers { get; set; }
        public string[] genres { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public Image[] images { get; set; }
        public string name { get; set; }
        public int popularity { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }


    public class Playlist : IResponse
    {
        public bool collaborative { get; set; }
        public string description { get; set; }
        public External_Urls external_urls { get; set; }
        public Followers followers { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public object[] images { get; set; }
        public string name { get; set; }
        public Owner owner { get; set; }
        public object primary_color { get; set; }
        public bool _public { get; set; }
        public string snapshot_id { get; set; }
        public Tracks tracks { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }


    public class Owner
    {
        public string display_name { get; set; }
        public External_Urls external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }


    public class Tracks
    {
        public string href { get; set; }
        public object[] items { get; set; }
        public int limit { get; set; }
        public object next { get; set; }
        public int offset { get; set; }
        public object previous { get; set; }
        public int total { get; set; }
    }

    //added by E
    public class CustomGetSpecifiedPlaylistModel : IResponse
    {
        public string description { get; set; }
        public string name { get; set; }
        public Tracks tracks { get; set; }
    }

    //same as items , added by E



    public class AllPlaylistModel : IResponse
    {
        public string href { get; set; }
        public PlaylistItem[] items { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public object previous { get; set; }
        public int total { get; set; }
    }

    public class PlaylistItem
    {
        public bool collaborative { get; set; }
        public string description { get; set; }
        public External_Urls external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public PlaylistImage[] images { get; set; }
        public string name { get; set; }
        public Owner owner { get; set; }
        public object primary_color { get; set; }
        public bool _public { get; set; }
        public string snapshot_id { get; set; }
        public PlaylistTracks tracks { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }


    public class PlaylistTracks
    {
        public string href { get; set; }
        public int total { get; set; }
    }

    public class PlaylistImage
    {
        public int? height { get; set; }
        public string url { get; set; }
        public int? width { get; set; }
    }




    public class PostCreatePlaylistModel : IResponse
    {
        public bool collaborative { get; set; }
        public string description { get; set; }
        public PExternal_Urls external_urls { get; set; }
        public PFollowers followers { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public object[] images { get; set; }
        public string name { get; set; }
        public Owner owner { get; set; }
        public object primary_color { get; set; }
        public bool _public { get; set; }
        public string snapshot_id { get; set; }
        public Tracks tracks { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class PExternal_Urls
    {
        public string spotify { get; set; }
    }

    public class PFollowers
    {
        public object href { get; set; }
        public int total { get; set; }
    }

    public class POwner
    {
        public string display_name { get; set; }
        public PExternal_Urls1 external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
    }

    public class PExternal_Urls1
    {
        public string spotify { get; set; }
    }

    public class PTracks
    {
        public string href { get; set; }
        public object[] items { get; set; }
        public int limit { get; set; }
        public object next { get; set; }
        public int offset { get; set; }
        public object previous { get; set; }
        public int total { get; set; }
    }

}
