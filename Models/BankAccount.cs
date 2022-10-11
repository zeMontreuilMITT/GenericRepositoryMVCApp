using System.ComponentModel.DataAnnotations;

namespace GenericRepositoryMVCApp.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        [Range(0, 1000)]
        public decimal Balance { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}

