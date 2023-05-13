using ConsoleApp1.Models;

namespace ConsoleApp1;

public class Menu
{
    private readonly GameEngine _engine = new();

    internal void ShowMenu(string name, DateTime date)
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine(
            $"Hello {name.ToUpper()}. It's {date}. This is your math's game. That's great that you're working on improving yourself\n");

        var isGameOver = false;

        do
        {
            Console.Clear();
            Console.WriteLine($@"What game would you like to play today? Choose from the options below:
                            V - History
                            A - Addition
                            S - Subtraction
                            M - Multiplication
                            D - Division
                            R - Random
                            Q - Quit the program");
            Console.WriteLine("---------------------------------");

            var gameSelected = Console.ReadLine();
            var questionCount = new int();
            
            Difficulty difficulty = Difficulty.Easy;

            if (gameSelected?.Trim().ToLower() != "v" && gameSelected?.Trim().ToLower() != "q")
            {
                Console.Clear();
                Console.WriteLine($@"How hard should the game be?
                            E - Easy
                            M - Medium
                            H - Hard");
                Console.WriteLine("---------------------------------");

                var difficultyFromConsole = Console.ReadLine();

                switch (difficultyFromConsole?.Trim().ToLower())
                {
                    case "e":
                        difficulty = Difficulty.Easy;
                        break;
                    case "m":
                        difficulty = Difficulty.Medium;
                        break;
                    case "h":
                        difficulty = Difficulty.Hard;
                        break;
                }
                
                Console.Clear();
                Console.WriteLine("How many questions do you want to solve?");
                questionCount = int.Parse(Console.ReadLine() ?? string.Empty);
            }

            if (gameSelected?.Trim().ToLower() == "r")
            {
                var random = new Random();
                var arr = new List<string>()
                {
                    "a",
                    "s",
                    "m",
                    "d"
                };
                
                var randomIndex = random.Next(0, arr.Count);
                gameSelected = arr[randomIndex];
            } 

            switch (gameSelected?.Trim().ToLower())
            {
                case "v":
                    Helpers.PrintGames();
                    break;
                case "a":
                    _engine.AdditionGame("Addition game", difficulty, questionCount);
                    break;
                case "s":
                    _engine.SubtractionGame("Subtraction game", difficulty, questionCount);
                    break;
                case "m":
                    _engine.MultiplicationGame("Multiplication game", difficulty, questionCount);
                    break;
                case "d":
                    _engine.DivisionGame("Division game", difficulty, questionCount);
                    break;
                case "q":
                    Console.WriteLine("Quit the program");
                    isGameOver = true;
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Environment.Exit(1);
                    break;
            }
        } while (!isGameOver);
    }
}