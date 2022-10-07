using GenericRepositoryMVCApp.Models;
using GenericRepositoryMVCApp.Data;

namespace GenericRepositoryMVCApp.DAL
{
    public class CustomerRepository : IRepository<Customer>
    {
        private GenericRepositoryMVCAppContext _context;
        public CustomerRepository(GenericRepositoryMVCAppContext context)
        {
            _context = context;
        }

        public void Add(Customer entity)
        {
            _context.Customers.Add(entity);
        }

        public void Delete(Customer entity)
        {
            _context.Customers.Remove(entity);
        }

        public Customer Get(int id)
        {
            return _context.Customers.Find(id);
        }

        public Customer Get(Func<Customer, bool> predicate)
        {
            return _context.Customers.First(predicate);
        }

        public ICollection<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public ICollection<Customer> GetList(Func<Customer, bool> predicate)
        {
            return _context.Customers.Where(predicate).ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public Customer Update(Customer entity)
        {
            _context.Customers.Update(entity);
            return entity;
        }
    }
}
