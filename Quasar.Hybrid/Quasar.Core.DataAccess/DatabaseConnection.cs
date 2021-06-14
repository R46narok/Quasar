using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace Quasar.Core.DataAccess
{
    /// <summary>
    /// Holds the threadpool which is connected to the database.
    /// </summary>
    public sealed class DatabaseConnection
    {
        #region Constant fields

        public const string DatabaseName = "quasar";
        public const string UserCollection = "users";
        public const string RoleCollection = "roles";

        #endregion

        private readonly MongoClient _client;

        public IMongoDatabase Database { get; private set; }

        public string ConnectionString => $@"";

        public DatabaseConnection(MongoDBConfig config)
        {
            // Check only in debug, in prod request the connection 
            // string from the app.json.

            var connectionString = config.ConnectionString;

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
