using System.Text.Json.Serialization;

namespace VFProyect_BACK.Models.REQUESTS
{
    public class EntrenadorRequest
    {
        [JsonPropertyName("NOMBRE")] public string NOMBRES { get; set; }
        [JsonPropertyName("EMAIL")] public string EMAIL { get; set; }
        [JsonPropertyName("TELEFONO")] public string TELEFONO { get; set; }
        [JsonPropertyName("DOCUMENTO")] public string DOCUMENTO { get; set; }
        [JsonPropertyName("ESPECIALIDAD")] public string ESPECIALIDAD { get; set; }
    }
}
