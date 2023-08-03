import axios, {Axios, AxiosInstance} from 'axios';
import {ApiException, PlacesClient} from "./gen/client";

const BASE_URL: string = "https://www.ave-system.com/api/";

// 1a. Access WebApi using ApiKey
const apiKey: string = "YOUR_API_KEY"; // replace with your API key

const axiosInstance: AxiosInstance = axios.create({
    baseURL: BASE_URL,
    headers: {
        'Content-Type': 'application/json',
        'Accept': 'application/json',
        'X-API-KEY': apiKey
    }
});

// 1b. Access WebApi using user SessionId (username and password)
const username: string = "YOUR_USERNAME"; // Replace with your username
const password: string = "YOUR_PASSWORD"; // Replace with your password


const placesClient: PlacesClient = new PlacesClient(BASE_URL, axiosInstance);

placesClient.getPlaces(0, 10, null, null, null).then((page) => {
        if (page.pageItems) {
            console.log("First 10 paged consumption places:")
            for (let place of page.pageItems) {
                console.log(`PlaceId: ${place.placeId}`);
            }
        }
    }
).catch((error: ApiException) => {
    if (error.status === axios.HttpStatusCode.Unauthorized) {
        console.log("Unauthorized. Please check your API key or username/password");
    } else {
        console.log(error);
    }
});
