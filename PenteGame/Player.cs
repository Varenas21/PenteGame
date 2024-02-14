using PenteGame.images;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace PenteGame
{
    internal class Player
    {
        // Player Name
        // Player Score
        // Player turn
        public String player2 { get; set; }
        public String player1 { get; set; }

        
        int player1Score, player2Score;
        bool playerTurn; // True => Player 1's turn, False => Player 2's turn


        public Player()
        {
            MainMenu mainGame = new MainMenu();
            if (player1 == null || player2 == null) { player1 = "Player 1"; player2 = "Player 2"; }

            switch (playerTurn)
            { 
                case true:
                    playerTurn = false;
                    Button btn_player1 = new Button
                    {
                        Background = Brushes.Black
                    };

                    mainGame.button = btn_player1;
                    break;
                case false:
                    playerTurn = true;
                    Button btn_player2 = new Button
                    {
                        Background = Brushes.White
                    };
                    mainGame.button = btn_player2;
                    break;
            }



        }

    }
}
