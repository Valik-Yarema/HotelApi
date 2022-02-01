﻿using Newtonsoft.Json;

namespace HotelApi.Models
{
    public abstract class Resource
    {
        [JsonProperty(Order = -2)]
        public string Href { get; set; }
    }
}