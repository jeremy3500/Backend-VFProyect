using System.Text.Json.Serialization;

namespace VFProyect_BACK.Models.REQUESTS
{
    public class LoginUserRequest
    {
        [JsonPropertyName("EMAIL")] public string EMAIL { get; set; }
        [JsonPropertyName("PASSWORD")] public string PASSWORD { get; set; }
    }
}
