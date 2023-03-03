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

        public static int SecondPlayerAIMove(int secondPlayerPosition, int secondPlayerBoard)
        {
            var randomGenerator = new Random();
            var randomNumber = randomGenerator.Next(0, 2);

            if (randomNumber == 0)
            {
                if (secondPlayerPosition > 0)
                {
                    secondPlayerPosition--;
                }
            }

            if (randomNumber == 1)
            {
                if (secondPlayerPosition < Console.WindowHeight - secondPlayerBoard)
                {
                    secondPlayerPosition++;
                }
            }

            return secondPlayerPosition;
        }

        public static void MoveBall(int firstPlayerBoardSize, int secondPlayerBoardSize, ref int ballPositionX, ref int ballPositionY, int firstPlayerPosition, int secondPlayerPosition, ref int firstPlayerResult, ref int secondPlayerResult, ref bool ballDirectionUp, ref bool ballDirectionRight)
        {
            if (ballPositionY == 0)
            {
                ballDirectionUp = false;
            }
            if (ballPositionY == Console.WindowHeight - 1)
            {
                ballDirectionUp = true;
            }
            if (ballPositionX == Console.WindowWidth - 1)
            {
                ballPositionX = Console.WindowWidth / 2;
                ballPositionY = Console.WindowHeight / 2;
                ballDirectionRight = false;
                ballDirectionUp = true;
                firstPlayerResult++;
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.WriteLine("First player wins!");
                Console.ReadKey();
            }
            if (ballPositionX == 0)
            {
                ballPositionX = Console.WindowWidth / 2;
                ballPositionY = Console.WindowHeight / 2;
                ballDirectionRight = true;
                ballDirectionUp = true;
                secondPlayerResult++;
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                Console.WriteLine("Second player wins!");
                Console.ReadKey();
            }

            if (ballPositionX < 3)
            {
                if (ballPositionY >= firstPlayerPosition
                    && ballPositionY < firstPlayerPosition + firstPlayerBoardSize)
                {
                    ballDirectionRight = true;
                }
            }

            if (ballPositionX >= Console.WindowWidth - 3 - 1)
            {
                if (ballPositionY >= secondPlayerPosition
                    && ballPositionY < secondPlayerPosition + secondPlayerBoardSize)
                {
                    ballDirectionRight = false;
                }
            }

            if (ballDirectionUp)
            {
                ballPositionY--;
            }
            else
            {
                ballPositionY++;
            }

            if (ballDirectionRight)
            {
                ballPositionX++;
            }
            else
            {
                ballPositionX--;
            }
        }
    }
}
