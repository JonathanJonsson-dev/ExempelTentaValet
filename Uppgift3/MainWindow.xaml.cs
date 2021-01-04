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

namespace Uppgift3
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
        Election election = new Election();
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            
            election.AddParty(txtBoxName.Text, txtBoxAbbreviation.Text, int.Parse(txtBoxReport.Text));
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            lstBox.ItemsSource = null;
            lstBox.ItemsSource = election.Parties;
            

           
        }

        private void lstBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Party party = (Party)lstBox.SelectedItem;
            lblTitle.Content = party.Name;
            txtBoxReport.Text = party.NumberOfVotes.ToString();
            
            
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Party searchResult = election.Search(txtBoxSearch.Text);
            if (searchResult == null)
            {
                lblSearchResult.Content = "Partiet saknas";
            }
            else
            {
                lblSearchResult.Content = searchResult.Name;
            }
            
        }
    }
}
