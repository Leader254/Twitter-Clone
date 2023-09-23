using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Social.Services.Users
{
    public class UsersService : IUserInterface
    {
        private readonly string _baseUrl = "https://jsonplaceholder.typicode.com/users";
        private readonly HttpClient _httpClient;
        public UsersService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Models.Users>> GetusersAsync()
        {
            var response = await _httpClient.GetAsync(_baseUrl);
            var content = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<List<Models.Users>>(content.ToString());
            if (users != null)
            {
                return users;
            }
            return new List<Models.Users>();
        }
    }
}