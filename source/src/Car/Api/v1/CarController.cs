
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.Car.Api.v1
{
    using CarRent.Car.Domain;
    [Route("api/v1/car")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _repository;

        public CarController(ICarRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var cars = _repository.GetAll();
            var carDtos = cars.Select(c => new CarResponseDto(c));
            return Ok(carDtos);

        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var car = _repository.GetById(new Guid(id));
            return Ok(car);
        }

        // POST api/<CarController>
        [HttpPost]
        public IActionResult Post([FromBody] CarResponseDto carResponseDto)
        {
            _repository.Add(new Car(carResponseDto));
            return Ok();
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
