using System;
					
public class Items
{
	public Temp currentTemp;
	
	public void Main()
	{
		currentTemp = new Temp();
		
		Console.WriteLine("Welcome, the current temperature is " + currentTemp.temp + "°C.");
		compare(currentTemp.temp);
	}
	public class Temp{
		//This should set the current temperature's value.
		public int temp = 2;
	}
	//This should compare the temperature to the limit and write the heat recommendations
	public void compare (int temp) {
		if(temp >= 30) {
			Console.WriteLine("It is recommended you remain hydrated, and avoid prolonged exposure to direct sunlight.");
		}
		else if(temp <= 10) {
			Console.WriteLine("Is is recommended you wear warm clothes.");
		}
		else if(temp <= 20) {
			Console.WriteLine("It is recommended you bring and wear a light jacket or hoodie.");
		}
		else if(temp <= 30) {
			Console.WriteLine("It is recommended that you enjoy the nice weather!");
		}
	}
}