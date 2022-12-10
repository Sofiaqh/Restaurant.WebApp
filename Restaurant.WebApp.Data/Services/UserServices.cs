using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.WebApp.Data
{
    public class UserServices : IUserServices
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;

        public UserServices(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _httpClient = httpClient;
            _appSettings = appSettings.Value;
        }

        public async Task<IEnumerable<Users>> GetAll()
        {
            IEnumerable<Users> users = new List<Users>();

            try
            {

                var request = new HttpRequestMessage(HttpMethod.Get, _appSettings.UserServices);

                var response = _httpClient.SendAsync(request).Result;

                if (response != null)
                {
                    var reponseBody = await response.Content.ReadAsStringAsync();

                    users = JsonConvert.DeserializeObject<IEnumerable<Users>>(reponseBody);

                    if (users == null)
                        return null;

                    return await Task.FromResult(users);
                }


                return users;
            }
            catch (Exception ex)
            {
                return users;
            }
        }
    }
}
