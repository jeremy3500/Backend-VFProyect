using System.Text.Json.Serialization;

namespace VFProyect_BACK.Models.RESPONSES
{


    public class UsuarioResponse
    {
        [JsonPropertyName("ID")] public int ID { get; set; }
        [JsonPropertyName("NOMBRES")] public string NOMBRES { get; set; }
        [JsonPropertyName("ROL")] public string ROL { get; set; }
        [JsonPropertyName("ESTADO")] public string ESTADO { get; set; }
    }
}
