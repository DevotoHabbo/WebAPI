
using System.Collections.Generic;

using WebAPI.Models;

namespace WebAPI.Data
{
    // MockPersonRepo is a testing env

    public class MockPersonRepo : IPersonRepo
    {
        public IEnumerable<Person> GetAllPerson()
        {
            var persons = new List<Person>
            {
                // Get the data => save into List<Person> object
                new Person { Id = 0, Firstname = "Phuong", Lastname = "Nguyen" },
                new Person { Id = 1, Firstname = "Lam", Lastname = "Nguyen" },
                new Person { Id = 2, Firstname = "Hieu", Lastname = "Nguyen" }
            };
            // Return the object for use
            return persons;
        }

        public Person GetPersonById(int id)
        {
            return new Person { Id = 0, Firstname = "Phuong", Lastname = "Nguyen" };
        }
    }
}
