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
    }
}
