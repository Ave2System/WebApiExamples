# Typescript Ave Web Api example

This example shows how to usage of the Ave Web Api with TypeScript 5.1.6 and [Axios](https://axios-http.com/docs/intro).
This example uses generated client code from [NSwag Studio](https://github.com/RicoSuter/NSwag/wiki/NSwagStudio) using
the [Ave WebApi swagger-2.0 definition](https://www.ave-system.com/api/v1/swagger.json), which can be found
in [`src/gen/client.ts`](src/gen/client.ts).

## What do you need

- Node & Typescript
- [Axios](https://axios-http.com/docs/intro)
- [Ave WebApi swagger-2.0 definition](https://www.ave-system.com/api/v1/swagger.json)
- Ave2 `ApiKey` or `username` and `password`

## Getting started with TS example

1. Clone this repository
2. Open the `Typescript` directory in your favorite IDE
3. Fill your `ApiKey` or `username` and `password` in the [`app.ts`](./src/app.ts)

    ```typescript
   const apiKey: string = "YOUR_API_KEY";
    ```

   or

    ```typescript
    const username : string = "YOUR_USERNAME";
    const password : string = "YOUR_PASSWORD";
    ```

4. To compile the project run
   ```shell
   npx tsc
   ```
5. Run the project using
   ```shell
   node dist/app.js
   ```
