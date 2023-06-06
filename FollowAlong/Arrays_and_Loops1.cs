using System;
					
public class Program
{
	public void Main()
	{
		string[] cars = {"Mustang", "Camero", "HellCat", "Corvette", "Viper", "McCleran"}; 
		Console.WriteLine(cars.Length);
		Console.WriteLine(cars[0]);
		Console.WriteLine(cars[1]);
		Console.WriteLine(cars[2]);
		
		Console.WriteLine("");
		
		foreach(var car in cars) {
			Console.WriteLine("I love my " + car + ".");
		}
	}
}