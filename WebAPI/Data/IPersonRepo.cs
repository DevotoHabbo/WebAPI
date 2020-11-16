
using System.Collections.Generic;

using WebAPI.Models;

namespace WebAPI.Data
{
    public interface IPersonRepo
    {
        IEnumerable<Person> GetAllPerson();
        Person GetPersonById(int id);

    }
}
