using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace PenteGame.images
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public int randomGridSize = 0;
        public MainMenu()
        {
            InitializeComponent();
        }


        private void Random_Click(object sender, RoutedEventArgs e)
        {
            Random randomNum = new Random();
            randomGridSize = randomNum.Next(9, 39);
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Classic_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Instructions_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.pente.net/instructions.html");
        }
    }
}
