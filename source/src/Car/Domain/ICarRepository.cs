using CarRent.Common.Domain;

namespace CarRent.Car.Domain
{
    public interface ICarRepository : IRepository<Car>
    {

        Car GetByNumber(string carNumber);

        IEnumerable<Car> GetAll();
    }
}
