internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.Write("hoe heet je: ");
        string naam = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"aangenaam kennismaking {naam} " );
        Console.ForegroundColor= ConsoleColor.White;
        Console.WriteLine("druk een toets om verder te gaan ...");
        Console.ReadKey();
    }
}