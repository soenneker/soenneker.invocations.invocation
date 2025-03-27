using System.Text.Json.Serialization;

namespace Soenneker.Invocations.Invocation;

/// <summary>
/// A base class for SignalR messages
/// </summary>
public class Invocation
{
    [JsonPropertyName("userId")]
    public string UserId { get; set; }

    public Invocation(string userId)
    {
        UserId = userId;
    }
}
