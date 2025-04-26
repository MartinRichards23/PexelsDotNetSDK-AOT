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
    public class CollectionMediaPage : Page
    {
        [JsonProperty("media")]
        public List<CollectionMedia> media { get; set; }
    }
}
