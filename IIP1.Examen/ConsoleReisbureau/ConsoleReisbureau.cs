using System;

class Program
{
   static void Main(string[] args)
   {
	  const double PrijsKind = 699;
	  const double PrijsVolw = 899;
	  const int LeeftijdGrens = 16;
	  char keuze = 'e';
	  int aantalKinderen = 0;
	  int aantalVolwassenen = 0;
	  double totaalPrijs = 0;
	  
	  
		do {
		Console.Clear();
		Console.WriteLine("Welkom bij Reisbureau Ibiza'");
		Console.WriteLine("(a) Reisgegevens invoeren");
		Console.WriteLine("(b)  Boeking bekijken");
		Console.WriteLine("(q) betalen en afsluiten");
		Console.WriteLine("");
		  
		  Console.Write("Maak uw keuze: ");
		  keuze = Convert.ToChar(Console.ReadLine());
		  switch (keuze) 
		  {
			  case 'a': 
			{
				Console.Write("Aantal personen: ");
				int aantalPersonen = Convert.ToInt32(Console.ReadLine());
				for (int i = 1; i == aantalPersonen; i++) 
				{
					Console.Write($"Leeftijd Persoon{i}: ");
					int LeeftijdPersoon = Convert.ToInt32(Console.ReadLine());
					if (LeeftijdPersoon <= LeeftijdGrens) 
					{
						aantalVolwassenen ++;
						
					}
					else {
						
						aantalKinderen++;
						
					}
				}
					Console.WriteLine($"Er werden {aantalKinderen} kinderen en {aantalVolwassenen} volwassenen geregistreed");
				  }  break;
			  
			  case 'b': {
						Console.WriteLine($"aantal kinderen:{aantalKinderen}");
						Console.WriteLine($"aantal kinderen: {aantalVolwassenen}");
						totaalPrijs = (aantalKinderen * PrijsKind) + (aantalVolwassenen * PrijsVolw);
						Console.WriteLine($"Totaal prijs: {Math.Round(totaalPrijs,2)}");     } break;
			  
			  
			  case 'q': 
			  {
				  
				  Console.Write("Wenst u een met cash of kredietkaart te betalen? (cash/krediet): ") ;
				  String Korting = Console.ReadLine();
				  if (Korting == "krediet") 
				  {
					  
					  double KortingPrijs = totaalPrijs * 0.03;
					  Console.WriteLine($"een toeslag van 3% wordt toegepast: {KortingPrijs}");
					  Console.WriteLine($"het totaal te betalen bedrag is {totaalPrijs + KortingPrijs}");
				  }
				  else {
					  
					  Console.WriteLine($"het totaal te betalen bedrag is {totaalPrijs}");
					  
				  }
				  
				  
			  } break;
			  
			  default: Console.WriteLine("Ongeldige Keuze"); break;
			  
		  } 
		} while (keuze != 'q');
		  
			Console.WriteLine("Bedankt voor het gebruik van Reisbureau Ibiza");
			Console.ReadKey();
		  

	  
		
		
   }
   
   
}