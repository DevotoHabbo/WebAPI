using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> opt) : base(opt)
        {

        }
        public DbSet<Person> People { get; set; }
    }
}
