using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class MockPersonRepo : IPersonRepo
    {
        public IEnumerable<Person> GetPersons()
        {
            var persons = new List<Person>
            {
                new Person { Id = 0, Firstname = "Phuong", Lastname = "Nguyen" },
                new Person { Id = 1, Firstname = "Lam", Lastname = "Nguyen" },
                new Person { Id = 2, Firstname = "Hieu", Lastname = "Nguyen" }
            };
            return persons;
        }

        public Person GetPersonById(int id)
        {
            return new Person { Id = 0, Firstname = "Phuong", Lastname = "Nguyen" };
        }
    }
}
