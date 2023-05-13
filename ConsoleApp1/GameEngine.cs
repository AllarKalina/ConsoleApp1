using System.Diagnostics;
using ConsoleApp1.Models;

namespace ConsoleApp1;

public class GameEngine
{
    internal void AdditionGame(string message, Difficulty difficulty, int questionCount)
    {
        var startTime = Stopwatch.GetTimestamp();

        var random = new Random();
        var score = 0;

        for (int i = 0; i < questionCount; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var difficultyRange = Helpers.GetDifficultyRange(difficulty);

            var firstNumber = random.Next(difficultyRange[0], difficultyRange[1]);
            var secondNumber = random.Next(difficultyRange[0], difficultyRange[1]);

            Console.WriteLine($"{firstNumber} + {secondNumber}");

            var result = Console.ReadLine();

            if (result != null && int.Parse(result) == firstNumber + secondNumber)
            {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect! Type any key for the next question");
                Console.ReadLine();
            }
        }
        
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);

        Console.WriteLine($"Game over! Your final score is {score}. Press any key to go back to the main menu.");
        Console.ReadLine();
        Helpers.AddToHistory(score, GameType.Addition, difficulty, elapsedTime);
    }

    internal void SubtractionGame(string message, Difficulty difficulty, int questionCount)
    {
        long startTime = Stopwatch.GetTimestamp();
        var random = new Random();
        var score = 0;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < questionCount; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var difficultyRange = Helpers.GetDifficultyRange(difficulty);

            firstNumber = random.Next(difficultyRange[0], difficultyRange[1]);
            secondNumber = random.Next(difficultyRange[0], difficultyRange[1]);

            Console.WriteLine($"{firstNumber} - {secondNumber}");

            var result = Console.ReadLine();

            if (result != null && int.Parse(result) == firstNumber - secondNumber)
            {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect! Type any key for the next question");
                Console.ReadLine();
            }
        }
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);


        Console.WriteLine($"Game over! Score {score}");
        Helpers.AddToHistory(score, GameType.Subtraction, difficulty, elapsedTime);
    }

    internal void MultiplicationGame(string message, Difficulty difficulty, int questionCount)
    {
        long startTime = Stopwatch.GetTimestamp();
        var random = new Random();
        var score = 0;

        int firstNumber;
        int secondNumber;

        for (int i = 0; i < questionCount; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var difficultyRange = Helpers.GetDifficultyRange(difficulty);

            firstNumber = random.Next(difficultyRange[0], difficultyRange[1]);
            secondNumber = random.Next(difficultyRange[0], difficultyRange[1]);

            Console.WriteLine($"{firstNumber} * {secondNumber}");

            var result = Console.ReadLine();

            if (result != null && int.Parse(result) == firstNumber * secondNumber)
            {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect! Type any key for the next question");
                Console.ReadLine();
            }
        }
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);


        Console.WriteLine($"Game over! Score {score}");
        Helpers.AddToHistory(score, GameType.Multiplication, difficulty, elapsedTime);
    }

    internal void DivisionGame(string message, Difficulty difficulty, int questionCount)
    {
        long startTime = Stopwatch.GetTimestamp();
        var score = 0;
        for (int i = 0; i < questionCount; i++)
        {
            Console.Clear();
            Console.WriteLine(message);

            var divisionNumbers = Helpers.GetDivisionNumbers();
            var firstNumber = divisionNumbers[0];
            var secondNumber = divisionNumbers[1];

            Console.WriteLine($"{firstNumber} / {secondNumber}");

            var result = Console.ReadLine();

            if (result != null && int.Parse(result) == firstNumber / secondNumber)
            {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your answer was incorrect! Type any key for the next question");
                Console.ReadLine();
            }
        }
        TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);


        Console.WriteLine($"Game over! Final score is {score}");
        Helpers.AddToHistory(score, GameType.Division, difficulty, elapsedTime);
    }
}