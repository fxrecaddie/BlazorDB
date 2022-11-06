using BlazorDatabase.Server.IService;
using BlazorDatabase.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDatabase.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Person_2Controller : ControllerBase
    {

        private PersonService_2 _personService_2;
        public Person_2Controller(PersonService_2 personService_2)
        {
            _personService_2 = personService_2;
        }

        [HttpGet]
        [Route("GetPerson")]
        public ActionResult<List<Person>> GetPerson()
        {
            return _personService_2.GetPerson();
        }

        [HttpPost]
        [Route("AddPerson")]
        public ActionResult AddPerson([FromBody]Person person) //[FromBody] - can as json obj 
        {
            _personService_2.AddPerson(person);
            return Ok();
        }

        [HttpDelete]
        [Route("DetelePerson")]
        public ActionResult DeletePerson([FromQuery] string PersonId)
        {
            _personService_2.DeletePerson(PersonId);
            return Ok();
        }

    }
}
