using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GenericRepositoryMVCApp.Models;

namespace GenericRepositoryMVCApp.Data
{
    public class GenericRepositoryMVCAppContext : DbContext
    {
        public GenericRepositoryMVCAppContext (DbContextOptions<GenericRepositoryMVCAppContext> options)
            : base(options)
        {
        }

        public DbSet<GenericRepositoryMVCApp.Models.BankAccount> BankAccount { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; }
    }
}
