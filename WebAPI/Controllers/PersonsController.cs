using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    // the route in the production env
    [Route("api/persons")]
    // route only run if there is a controller running behind the scene
    [ApiController]
    public class PersonsController : ControllerBase // inherite from
    {
        private readonly IPersonRepo _repository;

        public PersonsController(IPersonRepo repository)
        {
            _repository = repository;
        }
        // Get the data from MockPersonRepo then save it into new object _repository => push into production env
        //private readonly MockPersonRepo _repository = new MockPersonRepo();
        // Get api/persons
        [HttpGet]
        public ActionResult<IEnumerable<Person>> GetAllPerson()
        {
            var personItems = _repository.GetAllPerson();
            return Ok(personItems);
        }
        //Get api/persons/{id}
        [HttpGet("{id}")]
        public ActionResult<Person> GetPersonById(int id)
        {
            var personItem = _repository.GetPersonById(id);
            return Ok(personItem);
        }
}

}
