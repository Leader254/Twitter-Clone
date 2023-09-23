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
        public async Task<List<Models.Posts>> GetPostsAsync()
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
        public async Task<Models.Posts> GetPostAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/{id}");
            var content = await response.Content.ReadAsStringAsync();
            var post = JsonConvert.DeserializeObject<Models.Posts>(content.ToString());
            if (post != null)
            {
                return post;
            }
            return new Models.Posts();
        }

        public async Task<Models.Posts> GetPostByUserIdAsync(int userId)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}?userId={userId}");
            var content = await response.Content.ReadAsStringAsync();
            var posts = JsonConvert.DeserializeObject<List<Models.Posts>>(content.ToString()).ToList();
            if (posts != null && posts.Any())
            {
                return posts.FirstOrDefault();
            }
            return new Models.Posts();
        }
    }
}