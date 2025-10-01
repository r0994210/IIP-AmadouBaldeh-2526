using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(@"***********************
| GANSTA NAME BUILDER |
***********************");
		Console.WriteLine();
		Console.WriteLine();
		
        Console.Write("Give the first name of any Disney character: ");
        string DisneyNaam = Console.ReadLine();
		
        Console.Write("Give any workbench tool: ");
        string WorkbenchTool = Console.ReadLine();
		
        Console.Write("What is your last name: ");
        string LastName = Console.ReadLine();
		
        Console.WriteLine();
		
        Console.Write("Your gansta name: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine( DisneyNaam + $" 'the {WorkbenchTool} '" + LastName);
		
        Console.ReadKey();
    }
}