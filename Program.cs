using SnakeLadderPro_Day2;

namespace SnakeLadder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Program");

            Play game = new Play();
            game.Start();

        }
    }
}