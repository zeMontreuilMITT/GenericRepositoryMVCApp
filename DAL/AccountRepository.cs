using GenericRepositoryMVCApp.Data;
using GenericRepositoryMVCApp.Models;

namespace GenericRepositoryMVCApp.DAL
{
    public class AccountRepository : IRepository<BankAccount>
    {
        private GenericRepositoryMVCAppContext _db;
        public AccountRepository(GenericRepositoryMVCAppContext db)
        {
            _db = db;
        }
        public void Add(BankAccount entity)
        {
            _db.BankAccount.Add(entity);
        }

        public void Delete(BankAccount entity)
        {
            _db.BankAccount.Remove(entity);
        }

        public BankAccount Get(int id)
        {
            return _db.BankAccount.Find(id);
        }

        public BankAccount Get(Func<BankAccount, bool> predicate)
        {
            return _db.BankAccount.First(predicate);
        }

        public ICollection<BankAccount> GetAll()
        {
            return _db.BankAccount.ToList();
        }

        public ICollection<BankAccount> GetList(Func<BankAccount, bool> predicate)
        {
            return _db.BankAccount.Where(predicate).ToList();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public BankAccount Update(BankAccount entity)
        {
            _db.BankAccount.Update(entity);
            return entity;
        }
    }
}
