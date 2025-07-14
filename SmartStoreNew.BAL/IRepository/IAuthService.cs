using SmartStoreNew.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStoreNew.BAL.IRepository
{
    public interface IAuthService
    {
        Task<string> RegisterAsync(User user, string password);
        Task<string> LoginAsync(string userName, string password);
    }
}
