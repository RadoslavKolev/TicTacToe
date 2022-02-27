using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToeForm : Form
    {
        bool turn = true;                   //true = X turn, false = O turn
        bool against_computer = false;      // by default - 2 player mode
        int turn_count = 0;

        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void Author(object sender, EventArgs e)    // Author of the app
        {
            MessageBox.Show("By Radoslav Kolev", "Author");
        }

        private void Rules(object sender, EventArgs e)    //Rules for the game
        {
            MessageBox.Show(" 1. The game is played on a grid that's 3 squares by 3 squares.\n\n 2.You are X, your friend is O. Players take turns putting their marks in empty squares.\n\n 3.The first player to get 3 of her marks in a row(up, down, across, or diagonally) is the winner.\n\n 4. When all 9 squares are full, the game is over. If no player has 3 marks in a row, the game ends in a tie.", "Rules");
        }

        private void GameExit(object sender, EventArgs e)   // Exit the game
        {
            Application.Exit();
        }

        private void ButtonEnter(object sender, EventArgs e)    // When the mouse is over a button, it shows whoever turn it is
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void ButtonLeave(object sender, EventArgs e)    // When the mouse leaves the button, it hides whoever turn it is
        {
            Button b = (Button)sender;
            if (b.Enabled)
                b.Text = "";
        }

        private void PlayVsAnotherPlayer_Click(object sender, EventArgs e)
        {
            turn = true;
            p1.Text = "Player 1";
            p2.Text = "Player 2";
            turn_count = 0;             // reset the turns
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
        }      // Play vs Another player

        private void PlayVsComputer_Click(object sender, EventArgs e)
        {
            turn = true;
            p1.Text = "You";
            p2.Text = "Computer";
            turn_count = 0;             // reset the turns
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";           
        }           // Play vs computer

        private void ComputerCheck(object sender, EventArgs e)
        {
            if (p2.Text.ToUpper() == "COMPUTER")
                against_computer = true;
            else
                against_computer = false;
        }                  // Checks if you're playing vs the computer

        private void ButtonClick(object sender, EventArgs e)    // When you click a button we change the label, change the turn, disable the pushed button and check for win
        {
            if((p1.Text == "Player 1") || (p2.Text == "Player 2"))
                MessageBox.Show("You must specify the players names before you can start!\nType Computer for Player 2 to play against a computer!");
            else
            {
                Button b = (Button)sender; // Converts sender object as a button and saves it in b
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
                turn = !turn;        // It turns the rows each time when a button is clicked
                b.Enabled = false;   // After clicking, the button is disabled and it can't be changed!
                turn_count++;        // Counts the turns after clicking a button
                label2.Focus();
                CheckForWinner();
            }
            // Checking if you're playing against a computer and if it's O turn
            if ((!turn) && (against_computer))
                computer_make_move();
        }

        private void CheckForWinner() // Checks if there is any winner. If there is not - it's a draw
        {
            bool winner = false;

            // Horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                winner = true;

            // Vertical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;

            //Diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                winner = true;

            if (winner)
            {
                DisableButtons(); // if there is a winner, disable all the buttons
                string win = "";
                if (turn)
                {
                    win = p2.Text;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString(); //label is converted to int and increments with one with each O victory
                    turn = false;
                    Restart();
                }
                else
                {
                    win = p1.Text;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();  //label is converted to int and increments with one with each X victory
                    turn = true;
                    Restart();
                }
                if (win == "You")
                    MessageBox.Show("You win!", "Winner");
                else
                    MessageBox.Show(win + " wins!", "Winner");
            }
            else
            {
                if (turn_count == 9)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();    //label is converted to int and increments when no one wins
                    MessageBox.Show("The game is draw", "Draw");
                    turn = !turn;
                    Restart();
                }
            }
        }

        private void DisableButtons() // Disable all the buttons
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void Restart()
        {
            turn = !turn;               // turn the rows
            turn_count = 0;             // reset the turns
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
        }           // Restarts the game, keeps the score, turns the row

        private void NewGame(object sender, EventArgs e) // Restarts the game
        {
            turn = true;       // reset the values
            turn_count = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
        }

                                                                       // Computer Algorithm

        private void computer_make_move()
        {
            //priority 1:  get tic tac toe
            //priority 2:  block x tic tac toe
            //priority 3:  go for corner space
            //priority 4:  pick open space

            Button move = null;

            //look for tic tac toe opportunities
            move = look_for_win_or_block("O"); //look for win
            if (move == null)
            {
                move = look_for_win_or_block("X"); //look for block
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    }
                }
            }
            move.PerformClick();
        }           

        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }//end if
            }//end if

            return null;
        }

        private Button look_for_corner()
        {
            Console.WriteLine("Looking for corner");
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;
        }

        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);
            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }
    }
}
