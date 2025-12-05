using System.Text.Json.Serialization;

namespace VFProyect_BACK.Models.RESPONSES
{
    public class ClaseResponse
    {
        [JsonPropertyName("ID")] public int ID { get; set; }
        [JsonPropertyName("CLASE")] public string CLASE { get; set; }
        [JsonPropertyName("ENTRENADOR")] public string ENTRENADOR { get; set; }
        [JsonPropertyName("DIA")] public string DIA { get; set; }
        [JsonPropertyName("CUPOS")] public int CUPOS { get; set; }
        [JsonPropertyName("ESTADO")] public string ESTADO { get; set; }
    }
}
