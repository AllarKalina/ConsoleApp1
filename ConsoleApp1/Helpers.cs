using ConsoleApp1.Models;

namespace ConsoleApp1;

public class Helpers
{
    private static readonly List<Game> Games = new();

    internal static int[] GetDivisionNumbers()
    {
        var random = new Random();
        var firstNumber = random.Next(1, 99);
        var secondNumber = random.Next(1, 99);
    
        var result = new int[2];

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(1, 99);
            secondNumber = random.Next(1, 99);
        }
    
        result[0] = firstNumber;
        result[1] = secondNumber;
    
        return result;
    }

    internal static int[] GetDifficultyRange(Difficulty difficulty)
    {
        return difficulty switch
        {
            Difficulty.Easy => new[] { 1, 9 },
            Difficulty.Medium => new[] { 1, 20 },
            Difficulty.Hard => new[] { 1, 100 },
            _ => new[] { 1, 9 }
        };
    }

    internal static void AddToHistory(int gameScore, GameType gameType, Difficulty gameDifficulty, TimeSpan gameTime)
    {
        Games.Add(new Game
        {
            Date = DateTime.Now,
            Score = gameScore,
            Type = gameType,
            Difficulty = gameDifficulty,
            Time = gameTime
        });
    }

    internal static void PrintGames()
    {
        
        Console.Clear();
        Console.WriteLine("Games History");
        Console.WriteLine("-------------------------");
    
        foreach (var game in Games)
        {
            Console.WriteLine($"{game.Date}: time played {game.Time.TotalSeconds}sec - {game.Type} with {game.Difficulty} difficulty: {game.Score}pts");
        }
    
        Console.WriteLine("-------------------------\n");
        Console.WriteLine("Press any key to return to Main Menu");
        Console.ReadLine();
    }
}