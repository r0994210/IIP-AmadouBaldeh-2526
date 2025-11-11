using System;

class Program
{
   static void Main(string[] args)
   {
	Console.WriteLine(@"Bankautomaat
============");
	
	
	double StartSaldo = 500.00;
	
	Console.WriteLine($"huidige saldo: {Math.Round(StartSaldo,1)}");
	Console.WriteLine();

	
	Console.WriteLine($"a. afhaling");
	Console.WriteLine($"b. storting");
	Console.WriteLine($"c. stoppen");

	Console.WriteLine();

	Console.Write("je keuze: ");
	char keuze = Console.ReadKey().KeyChar;
	
	switch (keuze) 
	{
		case 'a': Console.WriteLine(); break;
		
		case 'b': Console.WriteLine(); break;
		
		case 'c': Console.WriteLine(); break;
		
		default: Console.WriteLine(" ongeldige keuze"); break;
	}
	
	if (keuze == 'a' ) 
	{
		Console.Write("Welk bedrag wil je afhalen: ");
		
		double afhaling = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine();
		
		double NieuweSaldo = StartSaldo - afhaling;
		Console.WriteLine($"afhaling ok - het nieuw saldo is {NieuweSaldo}");
	}
	
		if (keuze == 'b' ) 
	{
		Console.Write("Welk bedrag wil je storten: ");
		
		double storten = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine();
		
		double NieuweSaldo = StartSaldo + storten;
		Console.WriteLine($"storten ok - het nieuw saldo is {NieuweSaldo}");
	}
 
	
			if (keuze == 'c' ) 
	{
		Console.WriteLine();
		Console.Write("Bedankt tot ziens");
		
		Console.ReadKey();
	}
	
	
   }
}