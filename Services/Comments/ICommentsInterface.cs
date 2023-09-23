using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social.Services.Comments
{
    public interface ICommentsInterface
    {
        Task<List<Models.Comments>> GetcommentsAsync();
    }
}