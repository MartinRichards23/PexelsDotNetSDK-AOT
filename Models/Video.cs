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
    public class Video
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("width")]
        public int width { get; set; }

        [JsonProperty("height")]
        public int height { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("image")]
        public string image { get; set; }

        [JsonProperty("duration")]
        public int duration { get; set; }

        [JsonProperty("user")]
        public User user { get; set; }

        [JsonProperty("video_files")]
        public IEnumerable<VideoFile> videoFiles { get; set; }

        [JsonProperty("video_pictures")]
        public IEnumerable<VideoPicture> videoPictures { get; set; }
    }
}
