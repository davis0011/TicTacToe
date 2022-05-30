using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Move
    {
        private Button button;
        private string mark;
        private int playerTurn;
        public Move(Button button, string mark, int playerTurn)
        {
            this.button = button;
            this.mark = mark;
            this.playerTurn = playerTurn;
        }
        public Button GetButton()
        {
            return this.button;
        }
        public string Getmark()
        {
            return this.mark;
        }
        public int GetplayerTurn()
        {
            return this.playerTurn;
        }
    }
}
