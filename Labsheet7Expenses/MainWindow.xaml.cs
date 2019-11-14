using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<Expense> expenses;
        Random rng = new Random();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        //click to add expenses
        
        private void Expenses_Calculator_Loaded(object sender, RoutedEventArgs e) //method runs on window load
        {
            //create expense objects
            //Expense e1 = new Expense() { Category = "Travel", Amount = 20.99m, Date = new DateTime(2019, 10, 15) };
            //Expense e2 = new Expense() { Category = "Food", Amount = 9.95m, Date = new DateTime(2019, 10, 5) };
            //Expense e3 = new Expense() { Category = "Office", Amount = 4.80m, Date = new DateTime(2019, 10, 18) };

            Expense e1 = GetRandomExpense();
            Expense e2 = GetRandomExpense();
            Expense e3 = GetRandomExpense();
            //add them to a list
            expenses = new ObservableCollection<Expense>();
            expenses.Add(e1);
            expenses.Add(e2);
            expenses.Add(e3);
            //display the list in the window
            lbxExpenses.ItemsSource = expenses;
            txtBlkTotal.Text = Expense.TotalExpenses.ToString("C");

        }
        private void btnAddExpenses_Click(object sender, RoutedEventArgs e)
        {
            //create expenseitem
            //Expense e1 = new Expense()
            //{
            //    Category = "Office",
            //    Amount = 15.00m,
            //    Date = DateTime.Now
            //};
            //Expense e2 = new Expense()
            //{
            //    Category = "Travel",
            //    Amount = 79.80m,
            //    Date = DateTime.Now
            //};

            //add new expense item

            //expenses.Add(e1);
            //expenses.Add(e2);
            expenses.Add(GetRandomExpense());

            txtBlkTotal.Text = Expense.TotalExpenses.ToString("C");
            ////refresh screen
            //lbxExpenses.ItemsSource = null;  //blanks the existing list 
            //lbxExpenses.ItemsSource = expenses; //refreshes it with new values
        }

        private Expense GetRandomExpense()
        {
            //get rng category
            string[] categories = { "Office", "Travel", "Entertainment", "Food" };
            int randomNumber = rng.Next(0, 4);
            string rngCategory = categories[randomNumber];
            
            //get rng amount
            randomNumber = rng.Next(1, 10001);
            decimal randomAmount = (decimal)randomNumber / 100;

            //get rng date (in the last 30 days)
            randomNumber = rng.Next(0, 31);
            DateTime randomDate = DateTime.Now.AddDays(-randomNumber);//gives a date in the last 30 days

            //create an expense object with the random info
            Expense e1 = new Expense(randomAmount, randomDate, rngCategory);
            
            //return random object
            return e1;
        }
    }
}
