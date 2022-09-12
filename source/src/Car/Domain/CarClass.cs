using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    public class CarClass : Entity, IAggregateRoot
    {
        public CarClass(Guid id) : base(id)
        {

        }
        public string CarClassName { get; }
        public decimal DailyPrice { get;}

    }
}
