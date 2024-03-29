﻿using System;
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
        //bool isPlayer = true;
        //int p1CapCount = 0; // Need to initialize values otherwise we get an exception
        //int p2CapCount = 0;
        //bool isCPU = false;
        MainWindow mainWindow;
        public Button button;


        public MainMenu()
        {
            mainWindow = new MainWindow();
            InitializeComponent();
            int count = 1;
            int gridSize = mainWindow.randomGridSize;

            //Testing
            mainWindow.Show();

            // Making grid
            RowDefinition rowDefinition = new RowDefinition();
            ColumnDefinition columnDefinition = new ColumnDefinition();

            rowDefinition.Height = new GridLength(gridSize);
            columnDefinition.Width = new GridLength(gridSize);

            GridBoard.RowDefinitions.Add(rowDefinition);
            GridBoard.ColumnDefinitions.Add(columnDefinition);

            // Adding buttons dynamically
            for (int column = 0; column < gridSize; column++)
            {
                for (int row = 0; row < gridSize; row++)
                {
                    button = new Button(); // Buttons added
                    button.Content = count.ToString(); // Testing that it prints properly
                    button.Name = "Piece" + count.ToString(); // Naming the piece based off the location

                    //button.Style()
                    // Adding buttons on rows and columns
                    Grid.SetColumn(button, column);
                    Grid.SetRow(button, row);
                    GridBoard.Children.Add(button);


                    count++;
                }
            }
        }

        // On Click for the buttons
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (b.IsPressed == true) Console.WriteLine("Button clicked");
        }

    }
}
