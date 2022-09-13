namespace CarRent.Car.Api.v1
{
    using System.Text.Json.Serialization;
    public class CarResponseDto
    {
        [JsonPropertyName("id")]
        [JsonPropertyOrder(100)]
        public Guid CarId { get; set; }

        //[JsonPropertyName("car-number")]
        //[JsonPropertyOrder(200)]
        //public string CarNumber { get; set; }

        [JsonPropertyOrder(300)]
        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonPropertyOrder(400)]
        [JsonPropertyName("carClass")]
        public string CarClass { get; set; }

        [JsonPropertyOrder(500)]
        [JsonPropertyName("Type")]
        public string Type { get; set; }

        public CarResponseDto(Domain.Car car)
        {
            CarId = car.Id;
            //CarNumber = car.CarNumber.ToString();
            Brand = car.Brand.Id.ToString();
            Type = car.Type.Id.ToString(); ;
            CarClass = car.CarClass.Id.ToString(); ;

        }

        public CarResponseDto()
        {

        }

    }
}
