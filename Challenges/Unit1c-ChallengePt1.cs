using System;
					
public class Program
{
	public static void Main()
	{
		Random rnd = new Random();
		int guessThis = rnd.Next(1, 10);
		int number = 0;

		int x = 0;
			if(x != 3){
				while (guessThis != number)
				{
					Console.WriteLine("Pick a number between 1 and 10!");
					number = Convert.ToInt32(Console.ReadLine());
		
					if(guessThis > number){
						Console.WriteLine("Not quite, the number is higher than " + number + ".");
						x++;
					}
					if(guessThis < number){
						Console.WriteLine("Not quite, the number is lower than " + number + ".");
						x++;
					}
					if(guessThis == number){
						Console.WriteLine("Good job! The correct answer was " + guessThis + "!");
						break;
					}
					if(x == 3){
						Console.WriteLine("Sorry, you're out of attempts. The correct answer was " + guessThis + ".");
						break;
				}
			}
		}	
	}
}