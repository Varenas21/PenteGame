using PenteGame.images;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PenteGame
{

    public partial class MainWindow : Window
    {
        public int randomGridSize;
        public MainWindow()
        {
            InitializeComponent();
            MainMenu menu = new MainMenu();
            menu.Show();

        }


        private void Random_Click(object sender, RoutedEventArgs e)
        {
            MainMenu menu = new MainMenu();
            randomGridSize = int.Parse(UserInput.Text);
            Console.WriteLine("Grid Size Value: " + randomGridSize);
            menu.Show();

        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Classic_Click(object sender, RoutedEventArgs e)
        {
            MainMenu menu = new MainMenu();
            randomGridSize = 19;
            menu.Show();
        }

        private void Instructions_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.pente.net/instructions.html");
        }

    }
}