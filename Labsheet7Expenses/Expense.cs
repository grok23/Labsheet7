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
        //public decimal Amount { get; set; }

        private decimal _amount;

        public decimal Amount
        {
            get { return _amount; }
            set 
            {
                TotalExpenses += value;
                _amount = value; 
            }
        }

        public DateTime Date { get; set; }
        public string Category { get; set; } //this will become an enum with 4 categories {office, travel, entertainment, food}

        public static decimal TotalExpenses;

        //constructors
        public Expense() : this(0, DateTime.Now, "Unkown") { }

        public Expense(decimal amount, DateTime date, string category )
        {
            Amount = amount;
            Date = date;
            Category = category;

        }

        public override string ToString()
        {
            return $"{Category}  {Amount:C}  {Date.ToShortDateString()}";
        }

    }
}
