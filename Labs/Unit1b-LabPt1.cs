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
		public int temp = 30;
	}
	//This should compare the temperature to the limit and write the heat recommendations
	public void compare (int temp) {
		if(temp >= 30) {
			Console.WriteLine("It is recommended you remain hydrated, and avoid prolonged exposure to direct sunlight.");
		}
		else
		{
			Console.WriteLine("Enjoy the nice weather!");
		}
	}
}