using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace Quasar.Core.Device
{
    [BsonIgnoreExtraElements]
    public class Device
    {
        public string Name { get; set; }

        [BsonId] public string Owner { get; set; }
    }
}
