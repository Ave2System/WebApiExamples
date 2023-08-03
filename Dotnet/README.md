# Dotnet (C#) example Ave Web Api

This example shows how to usage of the Ave Web Api with dotnet 7.0. and [RestSharp](https://restsharp.dev/).
The Api is documented in the [swagger-2.0 specification](https://www.ave-system.com/api/v1/swagger.json).

## What do you need

- [dotnet 7.0](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Ave WebApi swagger-2.0 definition](https://www.ave-system.com/api/v1/swagger.json)
- Ave2 `ApiKey` or `username` and `password`

## Getting started with Dotnet example

1. Clone this repository
2. Open the `Dotnet.sln` in Visual Studio or Rider
3. Fill your `ApiKey` or `username` and `password` in the [`Program.cs`](./Dotnet/Program.cs)

    ```csharp
    const string apiKey = "YOUR_API_KEY";
    ```
   or
    ```csharp
    const string username = "YOUR_USERNAME";
    const string password = "YOUR_PASSWORD";
    ```

4. Set the `usedClient` variable to `apiKeyClient` or `SessionClient` depending on what you want to use. Comment the
   other one.

    ```csharp
    var usedClient = apiKeyClient;
    //var usedClient = sessionClient;
    ```

5. Run `Nuget restore`
6. Run the `Dotnet` project

---

## Dotnet.NSwag.Client example

This example show usage of the generated api client code
using [NSwag Studio](https://github.com/RicoSuter/NSwag/wiki/NSwagStudio) that can be found
in [`Dotnet.NSwag.Client/Generated/NswagClient.cs`](Dotnet.NSwag.Client/Generated/NswagClient.cs).
This example shows only usage of the generated client code with the `ApiKey` authentication. For the session based
please refer to the first [`C# Dotnet`](#dotnet-c-example-ave-web-api) example.