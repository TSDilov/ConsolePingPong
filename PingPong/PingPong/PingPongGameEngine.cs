﻿namespace PingPong
{
    public class PingPongGameEngine
    {
        public void Play()
        {
            var firstPlayerBoardSize = 4;
            var secondPlayerBoardSize = 4;
            var ballPositionX = Console.WindowWidth / 2;
            var ballPositionY = Console.WindowHeight / 2;
            var firstPlayerPosition = Console.WindowHeight / 2 - firstPlayerBoardSize / 2;
            var secondPlayerPosition = Console.WindowHeight / 2 - secondPlayerBoardSize / 2;

            ConsoleSettings();
            var drawer = new Drawer(new Writer());
            while (true)
            {
                Console.Clear();
                drawer.DrawFirstPlayer(firstPlayerPosition, firstPlayerBoardSize);
                drawer.DrawSecondPlayer(secondPlayerPosition, secondPlayerBoardSize);
                drawer.DrawTheBall(ballPositionX, ballPositionY);
                Thread.Sleep(60);
            }
        }

        private static void ConsoleSettings()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Console.CursorVisible = false;
        }
    }
}
