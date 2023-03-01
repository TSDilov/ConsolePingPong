using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Controller
    {
        public static int FirstPlayerMove(int firstPlayerPosition, int firstPlayerBoard)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (firstPlayerPosition > 0)
                    {
                        firstPlayerPosition--;
                    }
                }

                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (firstPlayerPosition < Console.WindowHeight - firstPlayerBoard)
                    {
                        firstPlayerPosition++;
                    }
                }
            }

            return firstPlayerPosition;
        }
    }
}
