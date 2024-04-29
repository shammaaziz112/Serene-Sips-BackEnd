using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entity;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstraction;

    public interface IUserService
    {
        public List<User> FindAll();
         public List<User> FindOne();
        public User CreateOne(User user);
        public User? DeleteOne(string email);
        public User UpdateOne(string id);

    }
