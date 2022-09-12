using CarRent.Common.Domain;

namespace CarRent.Customer.Domain
{
    public class Customer: Entity, IAggregateRoot
    {
        public Customer(Guid id) : base(id)
        {

        }

        public string PassportNumber { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

    }
}
