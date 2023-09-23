using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
        public async Task<List<Models.Comments>> GetcommentsAsync()
        {
            var response = await _httpClient.GetAsync(_baseUrl);
            var content = await response.Content.ReadAsStringAsync();
            var comments = JsonConvert.DeserializeObject<List<Models.Comments>>(content.ToString());
            if (comments != null)
            {
                return comments;
            }
            return new List<Models.Comments>();
        }
    }
}