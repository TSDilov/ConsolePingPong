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
                this.writer.PrintAtPosition(2, i, '|');
            }
        }

        public void DrawSecondPlayer(int secondPlayerPosition, int secondPlayerBoardSize)
        {
            for (int i = secondPlayerPosition; i < secondPlayerPosition + secondPlayerBoardSize; i++)
            {
                this.writer.PrintAtPosition(Console.WindowWidth - 1, i, '|');
            }
        }

        public void DrawTheBall(int x, int y)
        {
            this.writer.PrintAtPosition(x, y, '*');
        }

        public void DrawResult(int firstPlayerResult, int secondPlayerResult)
        {
            this.writer.PrintResult(firstPlayerResult, secondPlayerResult);
        }

        public void DrawIfFirtstPlayerScore()
        {
            this.writer.PrintFirstPlayerScore();
        }

        public void DrawIfSecondPlayerScore()
        {
            this.writer.PrintSecondPlayerScore();
        }
    }
}
