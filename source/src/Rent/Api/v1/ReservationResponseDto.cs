using CarRent.Rent.Domain;
using System.Text.Json.Serialization;

namespace CarRent.Rent.Api.v1
{
    public class ReservationResponseDto
    {
        [JsonPropertyName("id")]
        [JsonPropertyOrder(100)]
        public Guid RentId { get; set; }

        [JsonPropertyName("startDate")]
        [JsonPropertyOrder(200)]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("duration")]
        [JsonPropertyOrder(300)]
        public int Duration { get; set; }

        [JsonPropertyName("totalAmount")]
        [JsonPropertyOrder(400)]
        public decimal TotalAmount { get; set; }

        [JsonPropertyName("customer")]
        [JsonPropertyOrder(500)]
        public Guid Customer { get; set; }

        [JsonPropertyName("chosenCarClass")]
        [JsonPropertyOrder(600)]
        public Guid ChosenCarClass { get; set;}

        [JsonPropertyName("Contract")]
        [JsonPropertyOrder(700)]
        public Guid Contract { get; set; }

        public ReservationResponseDto(Reservation reservation)
        {
            RentId = reservation.Id;
            StartDate = reservation.StartDate;
            Duration = reservation.Duration;
            TotalAmount = reservation.TotalAmount;
            Customer = reservation.Customer.Id;
            ChosenCarClass = reservation.ChosenCarClass.Id;
            Contract = reservation.Contract.Id;


        }

        public ReservationResponseDto()
        {

        }
    }
}
