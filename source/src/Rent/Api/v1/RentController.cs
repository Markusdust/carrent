using CarRent.Car.Domain;
using CarRent.Rent.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.Rent.Api.v1
{
    [Route("api/rent")]
    [ApiController]
    public class RentController : ControllerBase
    {

        private readonly IRentRepsitory _repository;

        public RentController(IRentRepsitory repository)
        {
            _repository = repository;
        }



        // GET: api/<RentController>
        [HttpGet]
        public IActionResult GetAll()
        {
            var rents = _repository.GetAll();
            var rentDtos = rents.Select(r => new ReservationResponseDto(r));
            return Ok();
        }

        // GET api/<RentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
