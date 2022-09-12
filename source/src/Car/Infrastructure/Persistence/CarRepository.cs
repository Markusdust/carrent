using CarRent.Car.Infrastructure.Persistence;

namespace CarRent.Car.Infrastructure.Persistence
{
    using CarRent.Car.Domain;
    using System;

    public class CarRepository : ICarRepository
    {
        private readonly CarContext _carContext;

        public CarRepository(CarContext carContext)
        {
            _carContext = carContext;
        }

        public void Add(Car car)
        {
            _carContext.Cars.Add(car);
        }

        public void Update(Car car)
        {
            _carContext.Cars.Update(car);
        }

        public void Remove(Car car)
        {
            _carContext.Cars.Remove(car);
        }

        public Car GetById(Guid Id)
        {
           var car = _carContext.Cars.Find(Id);
           return car;
        }

        public Car GetByNumber(string carNumber)
        {
            var car = _carContext.Cars.Where(x => x.Equals(carNumber))
                .Select(x =>x).First();
            return car;
        }

        public IEnumerable<Car> GetAll()
        {
           return _carContext.Cars.ToList();
            

        }
    }
}