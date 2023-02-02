using Microsoft.AspNetCore.Mvc;

namespace Session_19.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonControllers: ControllerBase
    {
        [HttpGet(Name ="GetPerson")]
        public Person Get() {
            Person person = new Person();
            person.Name = "Chrissanthi";
            return person;
        }
    
    }
}
