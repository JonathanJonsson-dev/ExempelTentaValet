﻿using System;
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

namespace Uppgift1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int voteA = 0;
        int voteB = 0;
        int voteC = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (radioBtn1.IsChecked == true)
            {
                voteA++;
            }
            else if (radioBtn2.IsChecked == true)
            {
                voteB++;
            }
            else
            {
                voteC++;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VoteCounter voteCounter = new VoteCounter();
            char winner = voteCounter.ElectionWinner(voteA, voteB, voteC);

            if (winner == 'X')
            {
                lbl.Content = $"Det går inte att avgöra vinnande alternativ";
            }
            else
            {
                lbl.Content = $"Alternativ {winner} fick flest röster.";
            }
            
        }
    }
}
