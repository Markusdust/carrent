using CarRent.Car.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.Car.Api.v1
{
    [Route("api/v1/car")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _repository;

        public CarController(ICarRepository repository)
        {
            _repository = repository;
        }

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var cars = _repository.GetAll();
        //    var CarDtos = cars.Select()

        //}



        // GET: api/<CarController>
        [HttpGet]
        public IEnumerable<CarResponseDto> Get()
        {
            return new CarResponseDto[]
            {
                new CarResponseDto
                {
                    CarId =Guid.NewGuid(),
                    CarNumber = "XW82",
                    Brand ="Audi",
                    Type ="SVU",
                    CarClass ="Luxury"
                }

            };
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CarController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
