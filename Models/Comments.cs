// https://jsonplaceholder.typicode.com/comments
namespace Social.Models
{
    public class Comments
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; } // name of the commentor
        public string email { get; set; } // email of the commentor
        public string body { get; set; } // comment body
    }
}
