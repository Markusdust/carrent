using CarRent.Common.Domain;

namespace CarRent.Rent.Domain
{
    public interface IRentRepsitory : IRepository<Reservation>
    {
        IEnumerable<Reservation> GetAll();
    }
}
