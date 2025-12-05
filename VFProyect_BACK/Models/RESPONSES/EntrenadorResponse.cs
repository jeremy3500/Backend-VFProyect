using System.Text.Json.Serialization;

namespace VFProyect_BACK.Models.RESPONSES
{
    public class EntrenadorResponse
    {
        [JsonPropertyName("ID")] public int ID { get; set; }
        [JsonPropertyName("ENTRENADOR")] public string ENTRENADOR { get; set; }
        [JsonPropertyName("EMAIL")] public string EMAIL { get; set; }
        [JsonPropertyName("TELEFONO")] public string TELEFONO { get; set; }
        [JsonPropertyName("ESPECIALIDAD")] public string ESPECIALIDAD { get; set; }
        [JsonPropertyName("ESTADO")] public string ESTADO { get; set; }
    }
}
