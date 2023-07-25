# Example of Ave Web API usage in python
# More examples on Github https://github.com/Ave2System/WebApiExamples
# Swagger 2.0 definition https://www.ave-system.com/api/v1/swagger.json

import json

import requests

base_url = "https://www.ave-system.com/api/"

# 1a. Access WebApi using ApiKey
api_key = "YOUR_API_KEY"  # Replace with your API key
headers = {"X-Api-Key": api_key}

# 1b. Access WebApi using user SessionId (user and password)
use_session = False  # Set to True to use SessionId instead of ApiKey

username = "YOUR_USERNAME"  # Replace with your username
password = "YOUR_PASSWORD"  # Replace with your password

if use_session:
    session_response = requests.post(f'{base_url}/auth', headers={'content-type': 'application/json'},
                                     data=json.dumps({"Name": username, "Password": password}))

    if session_response.status_code != 200:
        print(f"Error: {session_response.status_code} {session_response.text}")
        exit(1)

    user = json.loads(session_response.text)
    session_id = user["sessionId"]
    print(f"Authorized as {user['fullName']} with Session ID: {session_id}")

    headers["X-Api-Key"] = session_id  # Replace ApiKey with SessionId (ApiKey and SessionId are interchangeable)

# 2. Get list of first 10 consumption places
response = requests.get(f"{base_url}/places", headers=headers, params={"start": 0, "limit": 10})

if response.status_code != 200:
    print(f"Error: {response.status_code} {response.text}")
    if response.status_code == 401:
        print("Unauthorized - Check your API key or username and password")
    exit(1)

data = json.loads(response.text)

places = data["PageItems"]

print("\nList of first 10 consumption places IDs:")
for place in places:
    print(f"place_id: {place['PlaceId']}")
