using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class SqlPersonRepo : IPersonRepo
    {
        private readonly PersonContext _context;

        public SqlPersonRepo(PersonContext context)
        {
            _context = context;
        }
        public IEnumerable<Person> GetAllPerson()
        {
            return _context.People.ToList();
        }

        public Person GetPersonById(int id)
        {
            return _context.People.FirstOrDefault(p => p.Id == id);
        }

    }
}
