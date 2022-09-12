using CarRent.Car.Domain;
using CarRent.Common.Domain;

namespace CarRent.Rent.Domain
{
    using Customer.Domain;

    public class Reservation: Entity , IAggregateRoot
    {
        public Reservation(Guid id) : base(id)
        {

        }

        public DateTime StartDate { get; set; }

        public int Duration { get; set; }

        public decimal TotalAmount { get; set; }

        public Customer Customer { get; set; }

        public CarClass ChosenCarClass { get; set; }

        public Contract Contract { get; set; }

    }
}
