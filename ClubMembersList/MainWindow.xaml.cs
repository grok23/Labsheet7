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

namespace ClubMembersList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Members> members;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LiBxMembers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //select an object from the list to display the details of on a double click
        }

        private void LiBxMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //select an object from the list to display the details of using just a simple click to select
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //add entry to list
        }

        private void dtPckrDate_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //select a date
        }

        private void txtBlkNumberMembers_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }
    }
}
