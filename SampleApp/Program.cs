using PexelsDotNetSDK.Api;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

try
{
    Console.WriteLine($"Runtime='{RuntimeInformation.FrameworkDescription}'");
    Console.WriteLine($"Is AOT='{!RuntimeFeature.IsDynamicCodeSupported}'");

    Console.WriteLine("Enter Pexels api key:");
    string? key = Console.ReadLine();

    PexelsClient client = new PexelsClient(key);

    Console.WriteLine();
    Console.WriteLine("Getting curated photos");
    var curated = await client.CuratedPhotosAsync();
    Console.WriteLine($"Curated: total='{curated.totalResults}'");

    //foreach (var p in curated.photos)
    //{
    //    Console.WriteLine($"id='{p.id}', alt='{p.alt}', url='{p.url}'");
    //}
    
    Console.WriteLine();
    Console.WriteLine("Getting search results");
    var searchResults = await client.SearchPhotosAsync("cat");
    Console.WriteLine($"Results: total='{searchResults.totalResults}'");

    //foreach (var p in searchResults.photos)
    //{
    //    Console.WriteLine($"id='{p.id}', alt='{p.alt}', url='{p.url}'");
    //}

    Console.WriteLine("Getting photo");
    await client.GetPhotoAsync(2014422);

    Console.WriteLine("Search video ");
    var videoResults = await client.SearchVideosAsync("nature");

    //foreach(var v in videoResults.videos)
    //{
    //    Console.WriteLine($"id='{v.id}', url='{v.url}'");
    //}

    Console.WriteLine("Getting popular video");
    await client.PopularVideosAsync();

    Console.WriteLine("Getting video");
    await client.GetVideoAsync(2499611);

    Console.WriteLine("Getting collections");
    await client.CollectionsAsync();

    Console.WriteLine("Getting featured collections");
    await client.FeaturedCollectionsAsync();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}