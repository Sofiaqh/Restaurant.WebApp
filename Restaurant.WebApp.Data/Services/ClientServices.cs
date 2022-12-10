using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.WebApp.Data
{
    public class ClientServices : IClientServices
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;

        public ClientServices(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _httpClient = httpClient;
            _appSettings = appSettings.Value;
        }

        public async Task<IEnumerable<Client>> GetClients()
        {
            IEnumerable<Client> client = new List<Client>();

            try
            {

                var request = new HttpRequestMessage(HttpMethod.Get, $"{_appSettings.BaseUrl}{_appSettings.GetAllClient}");

                var response = _httpClient.SendAsync(request).Result;

                if (response != null)
                {
                    var reponseBody = await response.Content.ReadAsStringAsync();

                    client = JsonConvert.DeserializeObject<IEnumerable<Client>>(reponseBody);

                    if (client == null)
                        return null;

                    return await Task.FromResult(client);
                }


                return client;
            }
            catch (Exception ex)
            {
                return client;
            }
        }



        public async Task<Client> GetClient(int id)
        {
            Client client = new();

            try
            {

                var request = new HttpRequestMessage(HttpMethod.Get, _appSettings.GetClientId);

                var response = _httpClient.SendAsync(request).Result;

                if (response != null)
                {
                    var reponseBody = await response.Content.ReadAsStringAsync();

                    client = JsonConvert.DeserializeObject<Client>(reponseBody);

                    if (client == null)
                        return new Client();

                    return await Task.FromResult(client);
                }


                return client;
            }
            catch (Exception ex)
            {
                return client;
            }

        }

    }

}
