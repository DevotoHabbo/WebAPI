using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/persons")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly MockPersonRepo _repository = new MockPersonRepo();
        // Get api/persons
        [HttpGet]
        public ActionResult<IEnumerable<Person>> GetAllPersons()
        {
            var personItems = _repository.GetPersons();
            return Ok(personItems);
        }
        // Get api/persons/{id}
        [HttpGet("{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            var personItem = _repository.GetPersonById(id);
            return Ok(personItem);
        }
    }

}
