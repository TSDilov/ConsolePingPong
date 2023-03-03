namespace PingPong
{
    public class Writer
    {
        public void PrintAtPosition(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symbol);
        }

        public void PrintResult(int firstPlayerResult, int secondPlayerResult)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 1, 0);
            Console.WriteLine(firstPlayerResult + "-" + secondPlayerResult);
        }

        public void PrintFirstPlayerScore()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 7, Console.WindowHeight / 2);
            Console.WriteLine("First player wins!");
            Console.ReadKey();
        }

        public void PrintSecondPlayerScore()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 7, Console.WindowHeight / 2);
            Console.WriteLine("Second player wins!");
            Console.ReadKey();
        }
    }
}
