using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet7Expenses
{
    public class Expense
    {
        //declare properties
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }

        
        public override string ToString()
        {
            return $"{Category}  {Amount:C}  {Date.ToShortDateString()}";
        }

    }
}
