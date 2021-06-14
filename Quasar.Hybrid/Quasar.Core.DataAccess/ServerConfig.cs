using System;
using System.Collections.Generic;
using System.Text;

namespace Quasar.Core.DataAccess
{
    public class ServerConfig
    {
        public MongoDBConfig MongoDB { get; set; } = new MongoDBConfig();
    }
}
