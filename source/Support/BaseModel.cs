using System.Text.Json.Serialization;

namespace PrismHRAPI.Support;

public class BaseModel
{

    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; } = null;

    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; } = null;

    [JsonPropertyName("sessionId")]
    public string? SessionId { get; set; } = null;

    [JsonPropertyName("infoMessage")]
    public List<string> infoMessage { get; set; } = new List<string>();

    [JsonPropertyName("updateMessage")]
    public string? updateMessage { get; set; } = null;
}

