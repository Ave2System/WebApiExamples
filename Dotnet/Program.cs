using System.Net;
using Dotnet.Models;
using RestSharp;

// Example of Ave Web API usage with RestSharp
// More examples on Github https://github.com/Ave2System/WebApiExamples
// Swagger 2.0 definition https://www.ave-system.com/api/v1/swagger.json

IRestClient SetupApiKeyClient(string baseApiUrl, string apiKey) {
    return new RestClient(baseApiUrl)
        .AddDefaultHeader("X-Api-Key", apiKey);
}

async Task<RestClient?> SetupSessionClient(string baseApiUrl, string username, string password) {
    var sessionClient = new RestClient(baseApiUrl);

    var sessionRequest = new RestRequest("auth", Method.Post)
        .AddJsonBody(new Login { Name = username, Password = password });

    var sessionResponse = await sessionClient.ExecuteAsync<User>(sessionRequest);
    if (sessionResponse.StatusCode != HttpStatusCode.OK) {
        Console.Error.WriteLine($"Error: {sessionResponse.StatusCode} {sessionResponse.StatusDescription}");
        return null;
    }

    var user = sessionResponse.Data;
    var sessionId = user?.SessionId;

    Console.WriteLine($"Signed as {user?.FullName} with sessionID {sessionId!}");

    sessionClient.AddDefaultHeader("X-Api-Key", sessionId!); // SessionId is interchangeable with ApiKey

    return sessionClient;
}

const string baseUrl = "https://www.ave-system.com/api/";

// 1a. Access WepApi using API key
const string apiKey = "YOUR_API_KEY"; // Replace with your API key
//using var apiKeyClient = SetupApiKeyClient(baseUrl, apiKey);

// 1b. Access WebApi using SessionId (username and password)
const string username = "YOUR_USERNAME"; // Replace with your username
const string password = "YOUR_PASSWORD"; // Replace with your password
using var sessionClient = await SetupSessionClient(baseUrl, username, password);

if (sessionClient == null) {
    Console.Error.WriteLine("Error: Failed to setup session client. Check your username and password.");
    return;
}

// 2. Choose one of the clients
var usedClient = sessionClient; // Use apiKeyClient or sessionClient by uncommenting above

// 3. Call Ave WebApi endpoints
// Get first 10 paged consumption places 
var request = new RestRequest("places")
              .AddQueryParameter("start", 0)
              .AddQueryParameter("limit", 10);

var response = await usedClient.ExecuteAsync<Page<Place>>(request);

if (response.StatusCode != HttpStatusCode.OK) {
    Console.Error.WriteLine($"Error: {response.StatusCode} {response.StatusDescription}");
    return;
}

Console.WriteLine("\nFirst 10 paged consumption places:");
var placesPage = response.Data;
foreach (var place in placesPage?.PageItems ?? Array.Empty<Place>()) {
    Console.WriteLine($"PlaceID: {place.PlaceId}");
}