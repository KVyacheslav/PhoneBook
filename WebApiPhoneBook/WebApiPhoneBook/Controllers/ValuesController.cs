using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiPhoneBook.Data;
using WebApiPhoneBook.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiPhoneBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IPersonData _people;

        public ValuesController(IPersonData people)
        {
            _people = people;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _people.GetPeople();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _people.InfoPerson(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Person person)
        {
            _people.AddPerson(person);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Person person)
        {
            _people.EditPerson(person);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _people.RemovePerson(id);
        }
    }
}
