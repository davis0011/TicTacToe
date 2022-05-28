namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public static char turn;
        public static char playerturn;
        public static string[] player1 = new string[2];
        public static string[] player2 = new string[2];
        public Form1()
        {
            InitializeComponent();
            turnpick();
           
        }
        void turnpick()
        {
            Random rd = new Random();
            int start = rd.Next(3);
            if (start == 1)
            {
                playerturn = '1';
                turn = 'X';
                player1[0] = "1";
                player1[1] = "X";
                player2[0] = "2";
                player2[1] = "O";

            }
            else
            {
                playerturn = '1';
                turn = 'O';
                player1[0] = "1";
                player1[1] = "O";
                player2[0] = "2";
                player2[1] = "X";
            }
        }
        void ChangeTurn()
        {
            if (turn == 'X')
                turn = 'O';
            else
            {
                turn = 'X';
            }
            if (playerturn == '1')
                playerturn = '2';
            else
                playerturn = '1';
        }
        void isWin()
        {
            if(button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "")
            {
                    MessageBox.Show("The winner is player" + playerturn + "!");
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                MessageBox.Show("The winner is player" + playerturn + "!");
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                MessageBox.Show("The winner is player" + playerturn + "!");
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                MessageBox.Show("The winner is player" + playerturn + "!");
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                MessageBox.Show("The winner is player" + playerturn + "!");
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                MessageBox.Show("The winner is player" + playerturn + "!");
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                MessageBox.Show("The winner is player" + playerturn + "!");
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                MessageBox.Show("The winner is player" + playerturn + "!");
            }
        }
        void enableButton()
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                return;
            }
            if (turn == 'X')
            {
                button1.Text = "X";
                isWin();
                ChangeTurn();
            }
            else
            {
                button1.Text = "O";
                isWin();
                ChangeTurn();
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "")
            {
                return;
            }
            if (turn == 'X')
            {
                button2.Text = "X";
                isWin();
                ChangeTurn();
            }
            else
            {
                button2.Text = "O";
                isWin();
                ChangeTurn();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text != "")
            {
                return;
            }
            if (turn == 'X')
            {
                button3.Text = "X";
                isWin();
                ChangeTurn();
            }
            else
            {
                button3.Text = "O";
                isWin();
                ChangeTurn();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text != "")
            {
                return;
            }
            if (turn == 'X')
            {
                button4.Text = "X";
                isWin();
                ChangeTurn();
            }
            else
            {
                button4.Text = "O";
                isWin();
                ChangeTurn();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text != "")
            {
                return;
            }
            if (turn == 'X')
            {
                button5.Text = "X";
                isWin();
                ChangeTurn();
            }
            else
            {
                button5.Text = "O";
                isWin();
                ChangeTurn();
            }
            isWin();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text != "")
            {
                return;
            }
            if (turn == 'X')
            {
                button6.Text = "X";
                isWin();
                ChangeTurn();
            }
            else
            {
                button6.Text = "O";
                isWin();
                ChangeTurn();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text != "")
            {
                return;
            }
            if (turn == 'X')
            {
                button7.Text = "X";
                isWin();
                ChangeTurn();
            }
            else
            {
                button7.Text = "O";
                isWin();
                ChangeTurn();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text != "")
            {
                return;
            }
            if (turn == 'X')
            {
                button8.Text = "X";
                isWin();
                ChangeTurn();
            }
            else
            {
                button8.Text = "O";
                isWin();
                ChangeTurn();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text != "")
            {
                return;
            }
            if (turn == 'X')
            {
                button9.Text = "X";
                isWin();
                ChangeTurn();
            }
            else
            {
                button9.Text = "O";
                isWin();
                ChangeTurn();
            }
        }
    }
}