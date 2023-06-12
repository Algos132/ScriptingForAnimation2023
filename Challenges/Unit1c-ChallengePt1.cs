using System;
					
public class Program
{
	public static void Main()
	{
        //sets the number that the player needs to guess.
		Random rnd = new Random();
		int guessThis = rnd.Next(1, 10);
		int number = 0;
        //sets the attempt to "0" which will be added to every attempt the player makes.
		int x = 0;
        //This sets the number of attempts you can make.
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
                    //Since x is the number of the attempt you're on (-1) when you finish your third attempt,
                    //this will display this message and end the game.
					if(x == 3){
						Console.WriteLine("Sorry, you're out of attempts. The correct answer was " + guessThis + ".");
						break;
				}
			}
		}	
	}
}