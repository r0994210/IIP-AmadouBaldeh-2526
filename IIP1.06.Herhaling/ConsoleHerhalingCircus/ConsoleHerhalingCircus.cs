using System;

class Program
{
   static void Main(string[] args)
   {
	   
	   
	const double PrijsVolwassenen = 19.90 ;
	const double PrijsKinderen = 12.50 ;
	double TicketVolwassenen = 0;
	double TicketKinderen = 0;
	char keuze = 'e';
	   
	do { 
	Console.Clear();
	Console.WriteLine("Welkom bij de ticketshop voor 'Circus Stromboli'");
	Console.WriteLine("");
	
	Console.WriteLine("(a) tickets toevoegen");
	Console.WriteLine("(b) winkelmandje tonen");
	Console.WriteLine("(c) winkelmandje wissen");
	Console.WriteLine("(q) Bestelling afronden");
	Console.WriteLine("");
	

	
	Console.Write("Je Keuze: ");
	 keuze = Convert.ToChar(Console.ReadLine());

	
		
		
		switch (keuze) 
	{
		
			case 'a' : {
			
			Console.Write("volwassenen: ");
			 TicketVolwassenen = Convert.ToDouble(Console.ReadLine());
			Console.Write("Kinderen: ");
			 TicketKinderen = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine($"er zijn tickets voor {TicketVolwassenen} volwassenen en {TicketKinderen} kinderen toegevoegd aan je winkelmandje");
			Console.ReadKey();
			} break;
			case 'b' : {
				Console.WriteLine($"Volwassenen: {TicketVolwassenen}");
				Console.WriteLine($"Kinderen: {TicketKinderen}");
				Console.ReadKey();
				}	break;
				
			case 'c' : {
				TicketVolwassenen = 0;
				TicketKinderen = 0;
				Console.WriteLine("Je winkelmandje is geleegd");
				Console.ReadKey();
				
			}	break;
			case 'q' : {
				Console.Clear();
				double PrijsBerekeningV = PrijsVolwassenen * TicketVolwassenen;
				double PrijsBerekeningK = PrijsKinderen * TicketKinderen;
				double TotaalPrijs = PrijsBerekeningK + PrijsBerekeningV;
				
				Console.WriteLine($"Totaalprijs {Math.Round(TotaalPrijs)}");
				Console.Write("Ben je jarig j/n? ");
				char jarig = Convert.ToChar(Console.ReadLine());
				
					if (jarig == 'j') 
					{
						
						Console.WriteLine("Gefeliciteerd! Je krijgt 9% korting op je totaalprijs");
						double KortingTotaalPrijs = TotaalPrijs / 1.09;
						
						Console.WriteLine($"Totaal te betalen: {Math.Round(KortingTotaalPrijs, 2)}");
						Console.WriteLine("Je hebt 7 bonuspunten verdient");
					} 
				
			}	break;
			
			
			default: Console.WriteLine("ongeldige keuze"); break;
		
	}
	
	} while (keuze != 'q');
	
	
			
		
   }
   
   
}