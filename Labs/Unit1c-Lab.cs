using System;

public class Program
{
    public static void Main() {

		//This asks the user to input a number that will determine how long the number pyramid will be.
		Console.WriteLine("Enter a number:");
		int x = Convert.ToInt32(Console.ReadLine());
		
	//changing the number after "i <= x" will expand or shrink the number pyramid.
		for(int i = 0; i <= x; i++) {

            //writes the value of i while until j = i
			for (int j = 0; j < i; j++) {
				Console.Write(i);
			}
            
            //creates a new line to separate the pyramid's "layers"
			Console.WriteLine();
			
		}
		
	}
}