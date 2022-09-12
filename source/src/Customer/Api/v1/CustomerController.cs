using CarRent.Customer.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.Customer.Api.v1
{
    using CarRent.Customer.Domain;

    [Route("api/v1/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = _repository.GetAll();
            var customerDtos = customers.Select(c => new CustomerResponseDto(c));
            return Ok(customerDtos);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var customer = _repository.GetById(new Guid(id));
            return Ok(customer);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public  IActionResult Post ([FromBody] CustomerResponseDto customerResponseDto)
        {
            _repository.Add(new Customer(customerResponseDto));
            return Ok();
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] CustomerResponseDto customerResponseDto)
        {
            _repository.Update(new Customer(customerResponseDto));
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{Customer}")]
        public void Delete([FromBody] CustomerResponseDto customerResponseDto)
        {
            _repository.Remove(new Customer(customerResponseDto));
        }
    }
}
