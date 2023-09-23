// https://jsonplaceholder.typicode.com/posts
namespace Social.Models
{
    public class Posts
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; } // title of the post
        public string body { get; set; } // body of the post
    }
}
