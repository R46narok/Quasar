using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson.Serialization.Attributes;

namespace Quasar.Core.DataAccess
{
    /// <summary>
    /// Represents how users' data is stored in a database.
    /// Unique id is ignored.
    /// </summary>
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
