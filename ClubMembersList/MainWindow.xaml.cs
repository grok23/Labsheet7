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
            //cmbBxMemberType.DataContext = Enum.GetValues(typeof(MemberType));
        }

        private void LiBxMembers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //select an object from the list to display the details of on a double click
        }

        private void LiBxMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //select an object from the list to display the details of using just a simple click to select
            //LiBxMembers.ItemsSource = members;
            txtBoxName.Text = LiBxMembers.SelectedItem.ToString();
            //txtBoxName.Text = LiBxMembers.SelectedItem.members.Name;
            //txtBoxName.Text = this.LiBxMembers.Name.ToString();
            //LiBxMembers.SelectedItem.Name;


            //return $"{Name}, {MembersType}, {JoinDate.ToShortDateString()}";

            // Name.ToString();

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            //string s = cmbBxMemberType.SelectedValue.ToString();
            Members m1 = new Members() { Name = txtBoxName.Text, JoinDate = dtPckrDate.SelectedDate.Value, MembersType = (MemberType)Enum.Parse(typeof(MemberType), cmbBxMemberType.SelectedValue.ToString()) };
            members.Add(m1);
            txtBlkNumberMembers.Text = Members.TotalMembers.ToString();

        }

        private void dtPckrDate_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //select a date
        }

        private void txtBlkNumberMembers_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void Main_Window_Loaded(object sender, RoutedEventArgs e)
        {
            //cmbBxMemberType.ItemsSource = Enum.MemberType.Text;

            members = new ObservableCollection<Members>();
            Members m1 = new Members() { Name = "Tom Jones", JoinDate = new DateTime (2015, 1, 23), MembersType = MemberType.OAP};
            Members m2 = new Members() { Name = "Mary Smith", JoinDate = new DateTime(2013, 6, 1), MembersType = MemberType.Student};

            members.Add(m1);
            members.Add(m2);

            LiBxMembers.ItemsSource = members;
            txtBlkNumberMembers.Text = Members.TotalMembers.ToString();


        }

        private void cmbBxMemberType_DropDownClosed(object sender, EventArgs e)
        {
            
            
        }

        private void txtBoxName_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
