// https://jsonplaceholder.typicode.com/users
namespace Social.Models
{
    public class Users
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public AddressDto? address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public CompanyDto? company { get; set; }
    }
}
