using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace Quasar.Core
{
    [BsonIgnoreExtraElements]
    public class User
    {
        public string Username { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int PasswordIterations { get; set; }
    }
}
