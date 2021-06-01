using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace Quasar.Core.DataAccess
{
    public sealed class DatabaseConnection
    {
        private readonly MongoClient _client;

        public const string DatabaseName = "quasar";
        public const string UserCollection = "users";
        public const string RoleCollection = "roles";
        public IMongoDatabase Database { get; private set; }

        public DatabaseConnection(string connectionString)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                if (string.IsNullOrWhiteSpace(connectionString))
                    throw new ArgumentException("Connection string cannot be empty.");
            }

            _client = new MongoClient(connectionString);
            Database = _client.GetDatabase(DatabaseName);
        }
    }
}
