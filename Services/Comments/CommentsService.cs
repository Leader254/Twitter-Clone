using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Social.Models;

namespace Social.Services.Comments
{
    public class CommentsService : ICommentsInterface
    {
        private readonly string _baseUrl = "https://jsonplaceholder.typicode.com/comments";
        private readonly HttpClient _httpClient;
        public CommentsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Models.Comments>> GetcommentsAsync(int postId)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/?postId={postId}");
            var content = await response.Content.ReadAsStringAsync();
            var comments = JsonConvert.DeserializeObject<List<Models.Comments>>(content.ToString());
            if (comments != null && comments.Any())
            {
                return comments;
            }
            return new List<Models.Comments>();
        }
    }
}