namespace Dotnet.Models;

public class User
{
    public string FullName { get; set; }
    public string LogOnName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Comment { get; set; }
    public string LastAccessTimestamp { get; set; }
    public string LlastAccessRelative { get; set; }
    public string LlogOnTimestamp { get; set; }
    public string LlastClientVersion { get; set; }
    public string SystemRole { get; set; }
    public string InternetRole { get; set; }
    public string ClientType { get; set; }
    public string ClientTypeDescription { get; set; }
    public bool IsItMe { get; set; }
    public string EncodedSessionId { get; set; }
    public string SessionId { get; set; }
    public string ApiKey { get; set; }
}