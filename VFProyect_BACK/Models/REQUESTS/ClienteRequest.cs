using System.Text.Json.Serialization;

namespace VFProyect_BACK.Models.REQUESTS
{
    public class ClienteRequest
    {
        [JsonPropertyName("NOMBRE")] public string NOMBRE { get; set; }
        [JsonPropertyName("EMAIL")] public string EMAIL { get; set; }
        [JsonPropertyName("TELEFONO")] public string TELEFONO { get; set; }
        [JsonPropertyName("DOCUMENTO")] public string DOCUMENTO { get; set; }

        [JsonPropertyName("SEXO")] public string SEXO { get; set; }
        [JsonPropertyName("ID_MEMBRESIA")] public int ID_MEMBRESIA { get; set; }
    }
}
