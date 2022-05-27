namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private static char turn;
        public Form1()
        {
            InitializeComponent();
            Random rd = new Random();
            int start = rd.Next(2);
            if (start == 0)
                turn = 'X';
            else
                turn = 'Y';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(turn == 'X')
            {
                button2.Text = "X";
            }
        }
    }
}