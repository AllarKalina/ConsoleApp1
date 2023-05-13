using ConsoleApp1;

var date = DateTime.UtcNow;
var name = GetName();
var menu = new Menu();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please enter your name:");
    return Console.ReadLine() ?? string.Empty;
}
