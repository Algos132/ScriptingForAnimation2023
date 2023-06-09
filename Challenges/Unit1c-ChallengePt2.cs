using System;
					
public class Program
{
	public static void Main()
	{
		//Prompts the user to input food they like.
		Console.WriteLine("3 of your favorite foods.");
		
		//Stores the information the user enters and sets them to the key words "favorite(1-3)" for an array to use later. Also assigns each input a number so the user knows what food was what number for the next prompt
		Console.Write("Enter #1: ");
		string favorite1 = Console.ReadLine();
		Console.Write("Enter #2: ");
		string favorite2 = Console.ReadLine();
		Console.Write("Enter #3: ");
		string favorite3 = Console.ReadLine();
		
		string[] foods = {favorite1, favorite2, favorite3};
		
		//Asks the user to choose a number between 1 and 3 which is attached to one
		Console.WriteLine();
		Console.Write("Out of these 3, which number was your favorite? ");
		int i = Convert.ToInt32(Console.ReadLine());
		
		//Prints the food they user wanted to see, and says that the food was a good choice! i - 1 is for the array, since the array starts at the number 0 and the prompt asks for a number between 1 to 3.
		Console.WriteLine("So " + foods[i - 1] + " are your favorite food? Good choice, I also love " + foods[i - 1] + "!");
	}
}