using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Drawer
    {
        private readonly Writer writer;

        public Drawer(Writer writer)
        {
            this.writer = writer;
        }

        public void DrawFirstPlayer(int firstPlayerPosition, int firstPlayerBoardSize)
        {
            for (int i = firstPlayerPosition; i < firstPlayerPosition + firstPlayerBoardSize; i++)
            {
                this.writer.PrintAtPosition(0, i, '|');
            }
        }

        public void DrawSecondPlayer()
        {

        }
    }
}
