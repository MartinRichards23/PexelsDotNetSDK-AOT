#if NET7_0_OR_GREATER

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using PexelsDotNetSDK.Models;
using System;

namespace PexelsDotNetSDK
{
    [JsonSerializable(typeof(Collection))]
    [JsonSerializable(typeof(CollectionMedia))]
    [JsonSerializable(typeof(CollectionMediaPage))]
    [JsonSerializable(typeof(CollectionPage))]
    [JsonSerializable(typeof(Page))]
    [JsonSerializable(typeof(Photo))]
    [JsonSerializable(typeof(PhotoPage))]
    [JsonSerializable(typeof(Source))]
    [JsonSerializable(typeof(User))]
    [JsonSerializable(typeof(Video))]
    [JsonSerializable(typeof(VideoFile))]
    [JsonSerializable(typeof(VideoPage))]
    [JsonSerializable(typeof(VideoPicture))]
    [JsonSerializable(typeof(RateLimit))]
    sealed partial class SerializerContext : JsonSerializerContext
    {
        public static string Serialize<T>(T item)
        {
            return JsonSerializer.Serialize(item, typeof(T), Default);
        }

        public static T? Deserialize<T>(string json)
        {
            JsonTypeInfo<T>? typeInfo = Default.GetTypeInfo(typeof(T)) as JsonTypeInfo<T>;

            if (typeInfo == null)
                throw new InvalidOperationException($"Type {typeof(T).Name} not found");

            return JsonSerializer.Deserialize<T>(json, typeInfo);
        }
    }
}

#endif
