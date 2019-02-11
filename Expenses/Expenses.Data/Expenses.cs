using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.Data
{
    public class Expenses
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public Location Location { get; set; }

        public Category Category { get; set; }

        public Account Account { get; set; }
    }
}
