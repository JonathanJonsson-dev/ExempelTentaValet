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

namespace Uppgift2
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            bool[] checkedValues = new bool[]
{
                (bool)chkModeraterna.IsChecked,
                (bool)chkCenterpartiet.IsChecked,
                (bool)chkLiberalerna.IsChecked,
                (bool)chkKristdemokraterna.IsChecked,
                (bool)chkSocialdemokraterna.IsChecked,
                (bool)chkVänsterpartiet.IsChecked,
                (bool)chkMiljöpartiet.IsChecked,
                (bool)chkSveriedemokraterna.IsChecked};

            VoteCounter voteCounter = new VoteCounter();
            int sum = voteCounter.CalculateMandate(checkedValues);

            lblResult.Content = $"Resultat: {sum} av 349";

            if (voteCounter.CheckMajority(sum))
            {
                lblMajority.Content = $"Majoritet Ja";
            }
            else
            {
                lblMajority.Content = $"Majoritet Nej";

            }

        }
    }
}
