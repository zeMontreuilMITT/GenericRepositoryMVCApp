using GenericRepositoryMVCApp.DAL;
using GenericRepositoryMVCApp.Models;

namespace GenericRepositoryMVCApp.BLL
{
    public class AccountBusinessLogic
    {
        private IRepository<BankAccount> repo;

        public AccountBusinessLogic(IRepository<BankAccount> repo)
        {
            this.repo = repo;
        }

        public List<BankAccount> GetAccountsByCustomerId(int customerId)
        {
            return repo.GetList(account => account.CustomerId == customerId).ToList();
        }

        public List<BankAccount> GetAllBalancesOverMillion()
        {
            return repo.GetList(account => account.Balance > 1000000).ToList();
        }

        public List<BankAccount> GetAllAccountsUnderValue(decimal value)
        {
            return repo.GetList(account => account.Balance < value).ToList();
        }
        
        public List<BankAccount> GetAllBankAccounts()
        {
            return repo.GetAll().ToList();
        }
    }
}
