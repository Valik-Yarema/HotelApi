using Newtonsoft.Json;

namespace HotelApi.Models
{
    public class RootResponse : Resource
    {
        [JsonProperty(Order = -2)]
        public Link Info { get; set; }
        [JsonProperty(Order = -1)]
        public Link Rooms { get; set; }
    }
}
