using CarRent.Car.Domain;

namespace CarRent.Car.Infrastructure.Persistence
{
    public class BrandRepository
    {

        private readonly CarContext _carContext;

        public BrandRepository(CarContext carContext)
        {
            _carContext = carContext;
        }

        public Domain.Brand GetById(Guid id)
        {
            var brand = _carContext.Brands.Find(id);
            return brand;
        }

        public void Add(Domain.Brand brand)
        {
            _carContext.Brands.Add(brand);
            _carContext.SaveChanges();
        }

        public void Update(Domain.Brand brand)
        {
            _carContext.Brands.Update(brand);
            _carContext.SaveChanges();
        }

        public void Remove(Domain.Brand brand)
        {
            _carContext.Brands.Remove(brand);
            _carContext.SaveChanges();
        }
    }
}
