using System;

public class Program
{
    public static void Main() {

	//changing the number after "i <= " will expand or shrink the number pyramid.
		for(int i = 0; i <= 9; i++) {

            //writes the value of i while until j = i
			for (int j = 0; j < i; j++) {
				Console.Write(i);
			}
            
            //creates a new line to separate the pyramid's "layers"
			Console.WriteLine();
			
		}
		
	}
}