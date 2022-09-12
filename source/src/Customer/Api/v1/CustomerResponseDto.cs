namespace CarRent.Customer.Api.v1
{
    using System.Text.Json.Serialization;
    
    public class CustomerResponseDto
    {
        [JsonPropertyName("id")]
        [JsonPropertyOrder(100)]
        public Guid CustomerId { get; set; }

        [JsonPropertyName("passport-number")]
        [JsonPropertyOrder(200)]
        public string PassportNumber { get; set; }

        [JsonPropertyName("firstname")]
        [JsonPropertyOrder(300)]
        public string Firstname { get; set; }

        [JsonPropertyName("Lastname")]
        [JsonPropertyOrder(400)]
        public string Lastname { get; set; }

        [JsonPropertyName("Street")]
        [JsonPropertyOrder(500)]
        public string Street { get; set; }

        [JsonPropertyName("City")]
        [JsonPropertyOrder(600)]
        public string City { get; set; }

        [JsonPropertyName("Country")]
        [JsonPropertyOrder(700)]
        public string Country { get; set; }

        public CustomerResponseDto(Domain.Customer customer)
        {
            CustomerId = customer.Id;
            PassportNumber = customer.PassportNumber;
            Firstname = customer.Firstname;
            Lastname = customer.Lastname;
            Street = customer.Street;
            City = customer.City;
            Country = customer.Country;
        }

        public CustomerResponseDto()
        {

        }
    }
}
