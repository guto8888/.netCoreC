using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;

namespace API.Services
{
    public interface IUserService
    {
        public void AddUser(UserModel model);
        public void UpdateUser(UserModel model);
        public UserModel Login(UserModel user);
    }
}