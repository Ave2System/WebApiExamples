# Ave Web Api Examples

This repository contains examples of how to use the Ave Web Api
with [swagger-2.0](https://www.ave-system.com/api/v1/swagger.json) definition.

## Getting started

1. Clone this repository
2. Choose one of the examples
3. Fill your `ApiKey` or `username` and `password` in the example
4. Run the example

### Examples

- [Dotnet (C#)](./Dotnet/README.md)
- [Python](./Python/README.md)
- [Typescript](./Typescript/README.md)

## Authentication

WebApi supports two types of authentication. Api key and session based authentication. Both are interchangeable using
same header name `X-Api-Key`.

### Api key

1. Generate a new Api Key in the Ave2 Client
2. Add the Api Key header to the requests `X-Api-Key`

### Session based authentication

1. `Post` to the auth endpoint `/auth` with the following body

    ```json
    {
      "Name": "YOUR_USERNAME",
      "Password": "YOUR_PASSWORD"
    }
    ```
   Both username and password are the same as you use to login to the Ave2 Client.

2. Add the session id to the requests header as `X-Api-Key`

---

## Notes

### ApiKey

- Recommended for **long** running processes, like a service that runs in the background.
- Valid until changed or revoked in the Ave2 Client (user management).

### Session

- Recommended for **short** running processes, like a web application with user access.
- Valid only for certain amount of time. If you get a `401` code (Unauthorized) in
  response, you need to re-authenticate.

---

## Swagger/OpenApi code generators

Using Swagger/OpenApi code generators is a great way to get started with the WebApi. It will generate all the models and
client code for you.

- [NSwag Studio](https://github.com/RicoSuter/NSwag/wiki/NSwagStudio) (C#, Typescript ...)
- [OpenAPI Generator](https://openapi-generator.tech/docs/generators) (Javascript, Typescript, Java, C#, Python,
  Kotlin...)

---

## Testing API

For testing we recommend using [Postman](https://www.postman.com/). It is a great tool for testing and documenting APIs
and was the most consistent among other. You can easily `import` our api into Postman by using the following link:

```
https://www.ave-system.com/api/v1/swagger.json
```

_**Warning** when testing endpoints with SwaggerUI 2.0 we found that SwaggerUI 2.0 corrupts binary data and files.
So we recommend using Postman or newer versions of SwaggerUI._

---

## Support and contribution

Any contributions to this project are welcome. Please see the
open [issues](https://github.com/Ave2System/WebApiExamples/issues). You can contact us
at [support-ave@geovap.cz](mailto:support-ave@geovap.cz)