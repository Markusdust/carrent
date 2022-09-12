


namespace CarRent.Customer.Infrastructure.Persistence
{
    using CarRent.Car.Infrastructure.Persistence;
    using CarRent.Customer.Domain;

    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _customerContext;

        public CustomerRepository(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }

        public void Add(Customer customer)
        {
            _customerContext.Customers.Add(customer);
            _customerContext.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _customerContext.Customers.Update(customer);
            _customerContext.SaveChanges();
        }

        public void Remove(Customer customer)
        {
            _customerContext.Customers.Remove(customer);
            _customerContext.SaveChanges();
        }

        public Customer GetById(Guid id)
        {
            var customer = _customerContext.Customers.Find(id);
            return customer;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customerContext.Customers.ToList();
        }
    }
}
