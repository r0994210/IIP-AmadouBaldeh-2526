using System;

class Program
{
   static void Main(string[] args)
   {
      Console.WriteLine(@"BMI CALUCALTOR
==============");


		Console.Write("lengte (in cm): ");
		int lengte = Convert.ToInt32(Console.ReadLine());
		
		double lengteInMeter = lengte/100.0;
		
		Console.Write("gewicht (in kg): ");
		int gewicht = Convert.ToInt32(Console.ReadLine());
		
		double gewichtD = Convert.ToDouble(gewicht);
		
		double BMI = gewichtD / (lengteInMeter * lengteInMeter);
		
		Console.WriteLine($"Je BMI bedraagt: {Math.Round(BMI,0)}");
		
		if (BMI < 18.5) 
		
		{ 
		Console.ForegroundColor = ConsoleColor.DarkYellow;
		Console.WriteLine("je bent ondergewicht");
		Console.ResetColor();
		
		}
		
		else if (BMI >= 18.5 && BMI <=25.1) 
		{
		     Console.ForegroundColor = ConsoleColor.Green;
			 Console.WriteLine("je gewicht is normaal");
			 Console.ResetColor();
			 
		}
		else if (BMI >= 25.0 && BMI <=30.1) 
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			 Console.WriteLine("je hebt overgewicht");
			 Console.ResetColor();
		}
		
		else if (BMI >=30.0) 
		{
			Console.ForegroundColor = ConsoleColor.Red;
			 Console.WriteLine("je hebt obesistas");
			 Console.ResetColor();
		}
		Console.ReadKey();
   }
}