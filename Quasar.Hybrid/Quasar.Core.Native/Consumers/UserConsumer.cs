using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Quasar.Core.Data;
using Quasar.Core.Models;

namespace Quasar.Core.Native.Consumers
{
    public class UserConsumer : Consumer
    {
        public UserConsumer(HttpClient client) : base(client)
        {
        }

        public event EventHandler<ConsumerEventArgs<ApplicationUser>> AuthenticationResult;

        public async Task AuthenticateAsync(LoginModel model)
        {
            var request = BuildHttpRequest(HttpMethod.Get, "api/user/authenticate", model);

            var response = await _client.SendAsync(request);
            string raw = await response.Content.ReadAsStringAsync();

            AuthenticationResult?.Invoke(this, new ConsumerEventArgs<ApplicationUser>
            {
                Consumable = JsonConvert.DeserializeObject<ApplicationUser>(raw),
                Status = response.StatusCode
            });
        }

        public event EventHandler<ConsumerEventArgs<bool>> AuthenticationByHashResult;
        public async Task AuthenticateByHashAsync(ApplicationUser model)
        {
            var request = BuildHttpRequest(HttpMethod.Get, "api/user/authenticate_hash", model);

            var response = await _client.SendAsync(request);
            string raw = await response.Content.ReadAsStringAsync();

            AuthenticationByHashResult?.Invoke(this, new ConsumerEventArgs<bool>
            {
                Consumable = JsonConvert.DeserializeObject<bool>(raw),
                Status = response.StatusCode
            });
        }

        public event EventHandler<ConsumerEventArgs<ApplicationUser>> RegistrationResult;

        public async Task RegisterAsync(RegisterModel model)
        {
            var request = BuildHttpRequest(HttpMethod.Post, "api/user/register", model);

            var response = await _client.SendAsync(request);
            string raw = await response.Content.ReadAsStringAsync();

            RegistrationResult?.Invoke(this, new ConsumerEventArgs<ApplicationUser>
            {
                Consumable = JsonConvert.DeserializeObject<ApplicationUser>(raw),
                Status = response.StatusCode
            });
        }

        private HttpRequestMessage BuildHttpRequest<T>(HttpMethod method, string uri, T content)
        {
            var request = new HttpRequestMessage(method, uri);
            request.Headers.Authorization = BearerHeader;

            string json = JsonConvert.SerializeObject(content);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            return request;
        }
    }
}
