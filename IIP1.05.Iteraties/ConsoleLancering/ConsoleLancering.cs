using System;

class Program
{
   static void Main(string[] args)
   {
   Console.Write("hoeveel seconden tot lancering? ");
    int lancering = Convert.ToInt32(Console.ReadLine());;
	Console.WriteLine("");
	
	Console.WriteLine("for versie:");
	for (int i = lancering; i > 0; i--)
	{
		Console.WriteLine($"{i}...");
		
		if (i == 0) {
			
			Console.WriteLine("lift off !");
		}
	}
	Console.WriteLine("");
	
	Console.WriteLine("While versie:");
   while (lancering > 0 ) 
   {
	   
	   Console.WriteLine($"{lancering}...");
	   lancering--;
	   
	   
   }
   	Console.WriteLine("");
	
	
	Console.WriteLine("do-while versie:");
   do 
   {
	   
	  Console.WriteLine($"{lancering}...");
	   lancering--;
   }
   while (lancering > 0 );
   
   

   
   
   Console.ReadKey();
   }
   
   
}