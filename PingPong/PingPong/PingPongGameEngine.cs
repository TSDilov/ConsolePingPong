namespace PingPong
{
    public class PingPongGameEngine
    {
        public void Play()
        {
            var firstPlayerBoardSize = 4;
            var secondPlayerBoardSize = 4;
            var ballPositionX = 0;
            var ballPositionY = 0;
            var firstPlayerPosition = Console.WindowHeight / 2 - firstPlayerBoardSize / 2;
            var secondPlayerPosition = Console.WindowHeight / 2 - secondPlayerBoardSize / 2;

            ConsoleSettings();
            var drawer = new Drawer(new Writer());
            while (true)
            {
                drawer.DrawFirstPlayer(firstPlayerPosition, firstPlayerBoardSize);
                drawer.DrawSecondPlayer(secondPlayerPosition, secondPlayerBoardSize);

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
