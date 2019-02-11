using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Data
{
    public class ExpenseContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Expenses> Expenses { get; set; }
        public DbSet<Location> Locations { get; set; }
        
        public ExpenseContext(DbContextOptions<ExpenseContext> options) : base(options)
        {

        }


    }
}
