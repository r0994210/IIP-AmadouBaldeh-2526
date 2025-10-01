internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Wat is jouw voornaam? ");
        string naam  = Console.ReadLine();
        Console.Write("Hoe oud ben je? ");
        int leeftijd = Convert.ToInt32(Console.ReadLine());
        Console.Write("Geef je lievelingsletter: ");
        char letter = Convert.ToChar(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine($"Hallo {naam} ! Jij bent {leeftijd} jaar.");
        Console.WriteLine($"Volgende jaar ben je {leeftijd + 1} jaar.");
        Console.WriteLine($"Jouw lievelingsletter is: {letter}"); 
        Console.ReadKey();
    }
}