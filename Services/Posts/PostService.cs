using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Social.Services.Posts
{
    public class PostService : IPostInterface
    {
        private readonly string _baseUrl = "https://jsonplaceholder.typicode.com/posts";
        private readonly HttpClient _httpClient;
        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Models.Posts>> GetpostsAsync()
        {
            var response = await _httpClient.GetAsync(_baseUrl);
            var content = await response.Content.ReadAsStringAsync();
            var posts = JsonConvert.DeserializeObject<List<Models.Posts>>(content.ToString());
            if (posts != null)
            {
                return posts;
            }
            return new List<Models.Posts>();
        }
    }
}