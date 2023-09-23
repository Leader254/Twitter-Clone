namespace Social.Services.Users
{
    public interface IUserInterface
    {
        public Task<List<Models.Users>> GetusersAsync();
    }
}