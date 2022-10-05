using System.ComponentModel.DataAnnotations;

namespace GenericRepositoryMVCApp.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string FullName { get; set; }
        public ICollection<BankAccount> Accounts { get; set; } = new HashSet<BankAccount>();

    }
}
