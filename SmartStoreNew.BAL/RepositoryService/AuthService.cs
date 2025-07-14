using SmartStoreNew.BAL.IRepository;
using SmartStoreNew.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStoreNew.BAL.RepositoryService
{
    public class AuthService : IAuthService
    {
        public Task<string> LoginAsync(string userName, string password)
        {
            throw new NotImplementedException();
        }

        public Task<string> RegisterAsync(User user, string password)
        {
            throw new NotImplementedException();
        }
    }
}
