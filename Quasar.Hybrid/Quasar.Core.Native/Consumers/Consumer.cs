using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Quasar.Core.Native.Consumers
{
    public class Consumer
    {
        protected readonly HttpClient _client;

        public Consumer(HttpClient client)
        {
            _client = client;
        }

        protected internal const string BearerToken = "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCIsImtpZCI6Ind6RVhzaHNZbElnZW9zQnFuODdhYyJ9.eyJpc3MiOiJodHRwczovL2Rldi14bi05LWx1ZC51cy5hdXRoMC5jb20vIiwic3ViIjoiQVlGQzBhS0FaQjRLNVljTVJVSzJPT3JmTURqQ0o1VFdAY2xpZW50cyIsImF1ZCI6Imh0dHBzOi8vbG9jYWxob3N0OjUwMDEiLCJpYXQiOjE2Mjc0MDUyNDQsImV4cCI6MTYyNzQ5MTY0NCwiYXpwIjoiQVlGQzBhS0FaQjRLNVljTVJVSzJPT3JmTURqQ0o1VFciLCJndHkiOiJjbGllbnQtY3JlZGVudGlhbHMifQ.IB6kYq-A0z_lUxyLEmFXiPKVh6HpuPYxRYElQIO6GfSDnOgn2BncJLG12VlhJfORd1wV6NnQFT6sLboErDNM_1j0kgb_FqJzj6Qc8vxbM36zW5ej2SmmDKsPDMT4YQwzCS4rLR99pU75RyVLbDdSPiNaUMknhLJlwHp7nRNWU3EitgwJijfgWzKe913hi6qSO8TcTrXt5-_f0nzSBMNCsNBwrbhkFZmjTTHZ-r-ApX9C78T6DLF5gF1wKYcuw3CEyz5JzcoE_87I2vj29TG1_Dm_qftTITbApglI8NC_0h04T-SGfL5bkLcZdLL1Na4zgXkIFThX_pKNAYHRofmalg";
        protected internal const string BearerScheme = "Bearer";

        protected internal AuthenticationHeaderValue BearerHeader =>
            new AuthenticationHeaderValue(BearerScheme, BearerToken);
    }
}
