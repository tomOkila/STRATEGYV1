using STRATEGY.CLIENT.DTOs;
using System.Text.Json;

namespace STRATEGY.WEBAPI.Helpers
{
    public class SerializerOrDeserialize
    {
        public static LocalStorageDTO Deserialize(string serializeString)
        => JsonSerializer.Deserialize<LocalStorageDTO>(serializeString)!;
        public static string Serialize(LocalStorageDTO model) => JsonSerializer.Serialize(model);
    }
}
