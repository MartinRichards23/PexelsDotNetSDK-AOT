﻿using System;
using System.Collections.Generic;
using System.Text;

#if NET7_0_OR_GREATER
using JsonProperty = System.Text.Json.Serialization.JsonPropertyNameAttribute;
#else
using Newtonsoft.Json;
#endif

namespace PexelsDotNetSDK.Models
{
    public class Photo
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("width")]
        public int width { get; set; }

        [JsonProperty("height")]
        public int height { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("photographer")]
        public string photographer { get; set; }

        [JsonProperty("photographer_url")]
        public string photographerUrl { get; set; }

        [JsonProperty("photographer_id")]
        public long? photographerId { get; set; }

        [JsonProperty("src")]
        public Source source { get; set; }

        [JsonProperty("liked")]
        public bool liked { get; set; }

        [JsonProperty("avg_color")]
        public string avgColor { get; set; }
        
        [JsonProperty("alt")]
        public string alt { get; set; }
    }
}
