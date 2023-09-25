using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social.Services.Posts
{
    public interface IPostInterface
    {
        Task<List<Models.Posts>> GetPostByUserIdAsync(int userId);
    }
}