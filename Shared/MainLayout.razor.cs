
using Microsoft.AspNetCore.Components;
using Social.Models;
using Social.Services.Users;

namespace Social.Shared
{
    public partial class MainLayout
    {
        [Inject]
        private IUserInterface _usersService { get; set; }
        private List<Users> users;
        private Users selectedUsers;

        protected override async Task OnInitializedAsync()
        {

            users = await _usersService.GetusersAsync();

        }
        // onclick on a user, execute the getSingleUser method
        public void getSingleUser(Users user)
        {
            selectedUsers = user;
        }


    }
}
