using CSE210_02.Classes;

namespace CSE210_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Do you want to start a New Game? ");
            string answer = Console.ReadLine();
            if (answer == "Y")
            {
                Game newGame = new Game();
                newGame.StartGame();
            }

        }
    }    
}