using System.Text.Json.Serialization;

namespace Cajero.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CalcularTipo
    {
        Te = 1,
        Fresa = 2,
        Cafe = 3
    }
}
