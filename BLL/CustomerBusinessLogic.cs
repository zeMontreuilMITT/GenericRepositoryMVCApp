using GenericRepositoryMVCApp.DAL;
using GenericRepositoryMVCApp.Models;

namespace GenericRepositoryMVCApp.BLL
{
    public class CustomerBusinessLogic
    {
        private IRepository<Customer> _repo;
        public CustomerBusinessLogic(IRepository<Customer> repository)
        {
            _repo = repository;
        }

        public ICollection<Customer> GetCustomersStartingWith(string nameStart)
        {
            return _repo.GetList(customer => customer.FullName.StartsWith(nameStart)).ToList();
        }

        public Customer GetCustomerStartingWith(string nameStart)
        {
            return _repo.Get(customer => customer.FullName.StartsWith(nameStart));
        }

        public ICollection<Customer> GetCustomers()
        {
            return _repo.GetAll();
        }
    }
}
