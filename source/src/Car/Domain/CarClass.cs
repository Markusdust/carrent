using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    public class CarClass : Entity, IAggregateRoot
    {
        public decimal DailyPrice { get;}

    }
}
