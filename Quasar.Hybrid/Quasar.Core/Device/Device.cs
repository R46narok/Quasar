using MongoDB.Bson.Serialization.Attributes;

namespace Quasar.Core
{
    [BsonIgnoreExtraElements]
    public class Device
    {
        public string Name { get; set; }

        [BsonId] public string Owner { get; set; }
    }
}
