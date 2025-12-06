using System.Text.Json.Serialization;

namespace VFProyect_BACK.Models.RESPONSES
{
    public class ClienteResponse
    {
        [JsonPropertyName("ID")] public int ID { get; set; }
        [JsonPropertyName("CLIENTE")] public string CLIENTE { get; set; }
        [JsonPropertyName("EMAIL")] public string EMAIL { get; set; }
        [JsonPropertyName("TELEFONO")] public string TELEFONO { get; set; }
        [JsonPropertyName("TIPO_MEMBRESIA")] public string TIPO_MEMBRESIA { get; set; }
        [JsonPropertyName("FECHA_FIN_MEMBRESIA")] public string FECHA_FIN_MEMBRESIA { get; set; }
        [JsonPropertyName("ESTADO")] public string ESTADO { get; set; }
    }
}
