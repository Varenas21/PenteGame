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
       // public 
        public int randomGridSize = 0;
        public MainMenu()
        {
            InitializeComponent();

        }


        private void Random_Click(object sender, RoutedEventArgs e)
        {
            randomGridSize = int.Parse(UserInput.Text);
            Console.WriteLine("Grid Size Value: " + randomGridSize);
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Classic_Click(object sender, RoutedEventArgs e)
        {
            randomGridSize = 19;
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Instructions_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.pente.net/instructions.html");
        }

    }
}
