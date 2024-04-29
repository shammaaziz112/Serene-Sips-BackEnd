using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction;

    public interface IUserRepository
    {
        public List<User> FindAll();
        public User CreateOne(User user);
        public User? FindOneByEmail(string email);
        public User UpdateOne(User updatedUser);
    }
