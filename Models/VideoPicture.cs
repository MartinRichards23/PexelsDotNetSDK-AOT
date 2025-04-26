using System;
using System.Collections.Generic;
using System.Text;

#if NET7_0_OR_GREATER
using JsonProperty = System.Text.Json.Serialization.JsonPropertyNameAttribute;
#else
using Newtonsoft.Json;
#endif

namespace PexelsDotNetSDK.Models
{
    public class VideoPicture
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("picture")]
        public string picture { get; set; }

        [JsonProperty("nr")]
        public int nr { get; set; }
    }
}
