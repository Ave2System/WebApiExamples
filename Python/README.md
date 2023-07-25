# Python example Ave Web Api

This is a simple example of how to use the Ave Web Api with
python [requests](https://requests.readthedocs.io/en/master/).
The Api is documented in the [swagger-2.0 specification](https://www.ave-system.com/api/v1/swagger.json).

## What do you need

- Python 3.6 or higher
- Installed all dependencies from [`requirements.txt`](requirements.txt)
- Ave2 `ApiKey` or `username` and `password`

## Getting started with Example

1. Clone this repository
2. Install dependencies
3. Set your `ApiKey` or `username` and `password` in [`main.py`](main.py)
   ```python
   api_key = "YOUR_API_KEY"  # Replace with your API key
   ```
   or
    ```python
   useSession = False  # Set to True to use SessionId instead of ApiKey
   username = "YOUR_USERNAME"  # Replace with your username
   password = "YOUR_PASSWORD"  # Replace with your password
   ```
4. Run `python main.py`
