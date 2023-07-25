using System.Net;
using Dotnet.NSwag.Client.Generated;

async Task<PlacePage?> GetPlaces(HttpClient client, int start = 0, int limit = 10) {
    var placesClient = new PlacesClient(client);
    try {
        return await placesClient.GetPlacesAsync(start, limit);
    } catch (ApiException e) {
        if (e.StatusCode == (int)HttpStatusCode.Unauthorized) {
            await Console.Error.WriteLineAsync("Error: Unauthorized. Check your API key.");
            return null;
        }

        Console.WriteLine(e.Message);
    }

    return null;
}

const string apiKey = "YOUR_API_KEY"; // Replace with your API key

using HttpClient client = new();
client.DefaultRequestHeaders.Add("X-Api-Key", apiKey);

var placesPage = await GetPlaces(client, 0, 20);
if (placesPage == null) return;

Console.WriteLine($"\nGot first {placesPage.Count} places");
foreach (var place in placesPage.PageItems) {
    Console.WriteLine($"PlaceID: {place.PlaceId}");
}