using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entity
{
    public class Category
    {
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        public Category(string id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }



    }
}