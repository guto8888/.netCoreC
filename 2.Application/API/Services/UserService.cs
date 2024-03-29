using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Repository;
using Repository.Entity;

namespace API.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(UserModel model)
        {
            UserEntity entity = new UserEntity()
            {
                PersonId = model.PersonId,
                Password = model.Password,
                Username = model.Username
            };

            _userRepository.Add(entity);
        }

        public void UpdateUser(UserModel model)
        {
            UserEntity entity = new UserEntity()
            {
                Id = model.Id,
                PersonId = model.PersonId,
                Password = model.Password,
                Username = model.Person.Name
            };

            _userRepository.Update(entity);
        }

        public UserModel Login(UserModel model)
        {
             UserEntity entity = new UserEntity()
            {
                Person = new PersonEntity()
                {
                    Email = model.Person.Email
                },
                Username = model.Username,
                Password = model.Password,
            };

            entity = _userRepository.Login(entity);

            if(entity != null)
            {
                model.Id = entity.Id;
                model.PersonId = entity.PersonId;
                model.Person.Email = entity.Person.Email;
                model.Username = entity.Username;
                model.Person.Name = entity.Person.Name;
                return model;
            }

            return null;
        }
    }
}