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
    public class VideoFile
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("quality")]
        public string quality { get; set; }

        [JsonProperty("file_type")]
        public string fileType { get; set; }

        [JsonProperty("width")]
        public int? width { get; set; }

        [JsonProperty("height")]
        public int? height { get; set; }

        [JsonProperty("fps")]
        public double? fps { get; set; }

        [JsonProperty("link")]
        public string link { get; set; }
    }
}
