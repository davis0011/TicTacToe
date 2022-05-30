namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public static char turn;
        public static int playerturn;
        public static bool gameFinished;
        public static int score1, score2;
        private Stack<Move> moves;
        public Form1()
        {
            InitializeComponent();
            turnpick();
            score1 = 0;
            score2 = 0;
            moves = new Stack<Move>();
        }
        void turnpick()
        {

            gameFinished = false;
            Random rd = new Random();
            int start = rd.Next(2);
            if (start == 1)
            {
                playerturn = 1;
                turn = 'X';

            }
            else
            {
                playerturn = 1;
                turn = 'O';
            }
            labelNowPlaying.Text = turn.ToString();
        }
        void ChangeTurn()
        {
            if (!gameFinished)
            {
                if (turn == 'X')
                    turn = 'O';
                else
                {
                    turn = 'X';
                }
                labelNowPlaying.Text = turn.ToString();
                if (playerturn == 1)
                    playerturn = 2;
                else
                    playerturn = 1;
            }
        }
        void isWin()
        {
            if(button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "")
            {
                gameFinished = true;  
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                gameFinished = true;
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                gameFinished = true;
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                gameFinished = true;
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                gameFinished = true;
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                gameFinished = true;
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                gameFinished = true;
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                gameFinished = true;
            }
            if (gameFinished)
            {
                if (playerturn == 1)
                {
                    score1++;
                    labelPlayer1.Text = score1.ToString();
                }
                else
                {
                    score2++;
                    labelPlayer2.Text = score2.ToString();
                }
                labelNowPlaying.Text = "None";
                MessageBox.Show("The winner is player" + playerturn + "!");
            }
            else
            {
                isDraw();
            }
        }

        void isDraw()
        {
            if (button1.Text!=""&&button2.Text!= ""&&button3.Text!=""&&button4.Text!=""&&button5.Text!=""&&
                button6.Text!=""&&button7.Text!=""&&button8.Text!=""&&button9.Text!="")
            {
                gameFinished = true;
                MessageBox.Show("Its a draw!!");
            }
        }
        private void undoButton_Click(object sender, EventArgs e)
        {
            if (gameFinished)
            {
                return;
            }
            if (moves.Count != 0)
            {
                Move undoMove = moves.Pop();
                undoMove.GetButton().Text = "";
                ChangeTurn();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "" || gameFinished)
            {
                return;
            }
            if (turn == 'X')
            {
                button1.Text = "X";
            }
            else
            {
                button1.Text = "O";
            }
            Move m = new Move(button1, turn.ToString(), playerturn);
            moves.Push(m);
            isWin();
            ChangeTurn();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "" || gameFinished)
            {
                return;
            }
            if (turn == 'X')
            {
                button2.Text = "X";
            }
            else
            {
                button2.Text = "O";
            }
            Move m = new Move(button2, turn.ToString(), playerturn);
            moves.Push(m);
            isWin();
            ChangeTurn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text != "" || gameFinished)
            {
                return;
            }
            if (turn == 'X')
            {
                button3.Text = "X";
            }
            else
            {
                button3.Text = "O";
            }
            Move m = new Move(button3, turn.ToString(), playerturn);
            moves.Push(m);
            isWin();
            ChangeTurn();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text != "" || gameFinished)
            {
                return;
            }
            if (turn == 'X')
            {
                button4.Text = "X";
            }
            else
            {
                button4.Text = "O";
            }
            Move m = new Move(button4, turn.ToString(), playerturn);
            moves.Push(m);
            isWin();
            ChangeTurn();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text != "" || gameFinished)
            {
                return;
            }
            if (turn == 'X')
            {
                button5.Text = "X";
            }
            else
            {
                button5.Text = "O";
            }
            Move m = new Move(button5, turn.ToString(), playerturn);
            moves.Push(m);
            isWin();
            ChangeTurn();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text != "" || gameFinished)
            {
                return;
            }
            if (turn == 'X')
            {
                button6.Text = "X";
            }
            else
            {
                button6.Text = "O";
            }
            Move m = new Move(button6, turn.ToString(), playerturn);
            moves.Push(m);
            isWin();
            ChangeTurn();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text != "" || gameFinished)
            {
                return;
            }
            if (turn == 'X')
            {
                button7.Text = "X";
            }
            else
            {
                button7.Text = "O";
            }
            Move m = new Move(button7, turn.ToString(), playerturn);
            moves.Push(m);
            isWin();
            ChangeTurn();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text != "" || gameFinished)
            {
                return;
            }
            if (turn == 'X')
            {
                button8.Text = "X";
            }
            else
            {
                button8.Text = "O";
            }
            Move m = new Move(button8, turn.ToString(), playerturn);
            moves.Push(m);
            isWin();
            ChangeTurn();
        }
        void resetboard()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
        void resetGame()
        {
            resetboard();
            score1 = 0;
            score2 = 0;
            labelPlayer1.Text = "0";
            labelPlayer2.Text = "0";
        }
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            if (!gameFinished)
            {
                return;
            }
            var res = MessageBox.Show("Do you want to start a new game?", "New Game", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                turnpick();
                gameFinished = false;
                while(moves.Count > 0)
                {
                    moves.Pop();
                }
                resetboard();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Do you want to reset the score?", "Reset Score", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                turnpick();
                gameFinished = false;
                while(moves.Count > 0)
                {
                    moves.Pop();
                }
                resetGame();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text != "" || gameFinished)
            {
                return;
            }
            if (turn == 'X')
            {
                button9.Text = "X";
            }
            else
            {
                button9.Text = "O";
            }
            Move m = new Move(button9, turn.ToString(), playerturn);
            moves.Push(m);
            isWin();
            ChangeTurn();
        }
    }
}