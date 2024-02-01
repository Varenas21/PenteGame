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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isPlayer = true;
        int p1CapCount;
        int p2CapCount;
        bool isCPU = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        Button[] buttonRows = new Button[] { };
        Button[] buttonColumns = new Button[] { };
    }
}