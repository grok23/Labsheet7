using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labsheet7Expenses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        //click to add expenses
        private void btnAddExpenses_Click(object sender, RoutedEventArgs e)
        {
            //create expenseitem
            Expense e1 = new Expense()
            {
                Category = "Office",
                Amount = 15.00m,
                Date = DateTime.Now
            };

            //add new expense item




        }

        private void Expenses_Calculator_Loaded(object sender, RoutedEventArgs e) //method runs on window load
        {
            //create expense objects
            Expense e1 = new Expense() { Category = "Travel", Amount = 20.99m, Date = new DateTime(2019, 10, 15) };
            Expense e2 = new Expense() { Category = "Food", Amount = 9.95m, Date = new DateTime(2019, 10, 5) };
            Expense e3 = new Expense() { Category = "Office", Amount = 4.80m, Date = new DateTime(2019, 10, 18) };
            //add them to a list
            List<Expense> expenses = new List<Expense>();
            expenses.Add(e1);
            expenses.Add(e2);
            expenses.Add(e3);
            //display the list in the window
            lbxExpenses.ItemsSource = expenses;

        }
    }
}
