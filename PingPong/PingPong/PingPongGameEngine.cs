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
            var firstPlayerPosition = 0;
            var secondPlayerPosition = 0;

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
