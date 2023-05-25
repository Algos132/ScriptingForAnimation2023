using System;
					
public class Programs
{
	public food fruit;
	public food grain;
    public food vegitable;
    public food meat;
	
	public void Main()
	{
		fruit = new food();
		grain = new food();
        vegitable = new food();
        meat = new food();
		
		fruit.quantity = 3;
        fruit.sustaining = 1.25f;}
        public fruit.eatOne true;

		grain.quantity = 5;
        grain.sustaining = 3f;}
        grain.eatOne = false;

        vegitable.quantity = 4;
        vegitable.sustaining = 2.5f;}
        public vegitable.eatOne = false;

        meat.quantity = 2;
		meat.sustaining = 4f};
        meat.eatOne == true;

		
		Console.WriteLine("you have " + fruit.quantity);
        if (fruit.eatOne == true)
            Console.WriteLine("You've eaten one + " + fruit.sustaining + " sustenance.");
        }

		Console.WriteLine(grain.quantity);
        if (grain.eatOne == true)
            Console.WriteLine("You've eaten one grain +" + grain.sustaining + " sustenance.");

        Console.WriteLine(vegitable.quantity);
        if (grain.eatOne == true)
            Console.WriteLine("You've eaten one grain +" + vegitable.sustaining + " sustenance.");

        Console.WriteLine(meat.quantity);
        if (meat.eatOne == true)
            Console.WriteLine("You've eaten one mean +" + meat.sustaining + " sustenance.");


	}

public class food {
	public int quantity;
	public float sustaining;
	public bool eatOne;
}