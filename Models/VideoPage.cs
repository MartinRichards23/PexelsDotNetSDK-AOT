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
    public class VideoPage : Page
    {
        [JsonProperty("videos")]
        public IEnumerable<Video> videos { get; set; }
    }
}
