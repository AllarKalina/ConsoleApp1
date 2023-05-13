namespace ConsoleApp1.Models;

public class Game
{
    internal DateTime Date { get; set; }
    
    internal int Score { get; set; }
    
    internal GameType Type { get; set; }
    
    internal TimeSpan Time { get; set; }

    internal Difficulty Difficulty {
        get;
        set;
    }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}

internal enum Difficulty
{
    Easy,
    Medium,
    Hard
}